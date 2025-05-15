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
using System.IO;
using Microsoft.Data.SqlClient;

namespace InventoryPosSystem.Model
{
    public partial class frmUserAdd : SampleAdd
    {
        public frmUserAdd()
        {
            InitializeComponent();
            guna2MessageDialog1.Parent = this;
        }
        public int id = 0;
        public override void Savebtn_Click(object sender, EventArgs e)
        {

            // before save we need validation
            if (MainClass.Validation(this) == false)
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog1.Show("Lütfen Hataları giderin");
                return;
            }
            else
            {
                string query = "";

                if (id == 0) //Insert
                {
                    query = @"Insert into users values(@name,@username,@pass,@phone,@image)";
                }
                else //update
                {
                    query = @"UPDATE users SET uName = @name,
                                                uUsername = @username,
                                                uPass = @pass,   
                                                uPhone = @phone,
                                                uImage = @image
                                                WHERE userID = @id";
                }

                Image temp = new Bitmap(Pictxt.Image);
                MemoryStream ms = new MemoryStream();
                temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imageByteArray = ms.ToArray();


                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@name", Nametxt.Text);
                ht.Add("@username", Usertxt.Text);
                ht.Add("@pass ", Passtxt.Text);
                ht.Add("@phone", Phonetxt.Text);
                ht.Add("@image", imageByteArray);

                if (MainClass.SQl(query, ht) > 0)
                {
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    guna2MessageDialog1.Show("Veri Başarıyla Kaydedildi");
                    id = 0;
                    Nametxt.Text = "";
                    Usertxt.Text = "";
                    Passtxt.Text = "";
                    Phonetxt.Text = "";
                    Pictxt.Image = InventoryPosSystem.Properties.Resources.pngfind_com_account_icon_png_5357481;
                    Nametxt.Focus();
                }
            }
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
            string query = @"select uImage from users where userID = " + id + "";
            SqlCommand cmd = new SqlCommand(query, MainClass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Byte[] imageArray = (byte[])dt.Rows[0]["uImage"];
                byte[] imageByteArray = imageArray;
                Pictxt.Image = Image.FromStream(new MemoryStream(imageArray));
            }
        }

        private void frmUserAdd_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                LoadImage();
            }
           
        }

        private void Passtxt_IconRightClick(object sender, EventArgs e)
        {

            try
            {
                if (Passtxt.PasswordChar == '\0')
                {
                    Passtxt.IconRight = ımageList1.Images[1];
                    Passtxt.PasswordChar = '*';
                }
                else
                {
                    Passtxt.IconRight = ımageList1.Images[0];
                    Passtxt.PasswordChar = '\0';
                }
            }
            catch (Exception ex)
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog1.Show("Geçersiz kullanıcı adı ve şifre :" + ex.Message);
            }
        }
    }
        
}
