using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryPosSystem.Model
{
    public partial class frmProductAdd : SampleAdd
    {
        public frmProductAdd()
        {
            InitializeComponent();
            guna2MessageDialog1.Parent = this;
        }
        public int id = 0;
        public int catID = 0;
        public override void Savebtn_Click(object sender, EventArgs e)
        {
            if (!MainClass.Validation(this))
            {


                ShowMessage("Lütfen Hataları giderin", Guna.UI2.WinForms.MessageDialogIcon.Error);
                return;
            }

            try
            {
                string query;
                byte[] imageByteArray = null;
                if (Pictxt.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        Bitmap temp = new Bitmap(Pictxt.Image);
                        temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        imageByteArray = ms.ToArray();
                    }
                }

                Hashtable ht = new Hashtable();
                ht.Add("@name", Nametxt.Text);
                ht.Add("@pCatID", Convert.ToInt32(cbCategory.SelectedValue));
                ht.Add("@barcode", Barcodetxt.Text.Trim()); // Fixed space in parameter name
                ht.Add("@cost", Convert.ToDouble(Costxt.Text));
                ht.Add("@saleprice", Convert.ToDouble(Selltxt.Text));
                ht.Add("@image", imageByteArray ?? (object)DBNull.Value);

                if (id == 0) // Insert
                {
                    query = @"INSERT INTO Product 
                     (pName, pCatID, qBarcode, pCost, pPrice, pImage) 
                     VALUES 
                     (@name, @pCatID, @barcode, @cost, @saleprice, @image)";
                }
                else // Update
                {
                    query = @"UPDATE Product SET 
                      pName = @name,
                      pCatID = @pCatID,
                      qBarcode = @barcode,
                      pCost = @cost,
                      pPrice = @saleprice,
                      pImage = @image
                      WHERE proID = @id";
                    ht.Add("@id", id);
                }

                // Execute SQL
                if (MainClass.SQl(query, ht) > 0)
                {
                    ShowMessage("Veri Başarıyla Kaydedildi", Guna.UI2.WinForms.MessageDialogIcon.Information);
                    ResetForm();
                }
            }
            catch (FormatException)
            {
                ShowMessage("Geçersiz sayı formatı!", Guna.UI2.WinForms.MessageDialogIcon.Error);
            }
            catch (SqlException ex)
            {
                ShowMessage($"SQL Hatası: {ex.Message}", Guna.UI2.WinForms.MessageDialogIcon.Error);
            }
            catch (Exception ex)
            {
                ShowMessage($"Genel Hata: {ex.Message}", Guna.UI2.WinForms.MessageDialogIcon.Error);
            }
        }

        private void ShowMessage(string message, Guna.UI2.WinForms.MessageDialogIcon icon)
        {
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            guna2MessageDialog1.Icon = icon;
            guna2MessageDialog1.Show(message);
        }

        private void ResetForm()
        {
            id = 0;
            Nametxt.Text = "";
            Barcodetxt.Text = "";
            cbCategory.SelectedIndex = -1;
            Costxt.Text = "";
            Selltxt.Text = "";
            Pictxt.Image = InventoryPosSystem.Properties.Resources.Shopping_Bag;
            Nametxt.Focus();
        }
        public string Filepath = "";
        Byte[]? imageByteArray;
        private void Brsbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images (.jpg, .png)|*.png; *.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Filepath = ofd.FileName;
                Pictxt.Image = new Bitmap(Filepath);
            }
        }
        private void LoadImage()
        {
            string query = @"select pImage from Product where proID = " + id + "";
            SqlCommand cmd = new SqlCommand(query, MainClass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Byte[] imageArray = (byte[])dt.Rows[0]["pImage"];
                byte[] imageByteArray = imageArray;
                Pictxt.Image = Image.FromStream(new MemoryStream(imageArray));
            }
        }

        private void frmProductAdd_Load(object sender, EventArgs e)
        {
            string query = @"Select catID 'id' , catName 'name' from Category";
            MainClass.CBFill(query, cbCategory);
            if (id > 0)
            {
                cbCategory.SelectedValue = catID;
                LoadImage();
            }
        }
    }
}
