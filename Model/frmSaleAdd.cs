using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryPosSystem.Model
{
    public partial class frmSaleAdd : Sample
    {
        public frmSaleAdd()
        {
            InitializeComponent();
            guna2MessageDialog1.Parent = this;
        }
        public int id = 0;
        public int cusID = 0;

        private void frmSaleAdd_Load(object sender, EventArgs e)
        {
            try
            {
                guna2DataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
                if (guna2DataGridView1.Columns.Contains("dgvqty"))
                    guna2DataGridView1.Columns["dgvqty"].ReadOnly = false; 

                string[] readOnlyColumns = { "dgvid", "dgvproid", "dgvname", "dgvPrice", "dgvAmount", "dgvCost", "dgvDel", "dgvProduct" };
                foreach (string col in readOnlyColumns)
                {
                    if (guna2DataGridView1.Columns.Contains(col))
                        guna2DataGridView1.Columns[col].ReadOnly = true;                }

                string qry = @"SELECT cusID AS id, cusName AS name FROM Customer";
                MainClass.CBFill(qry, cbCustomer);
                if (cusID > 0)
                {
                    cbCustomer.SelectedValue = cusID;
                    LoadForEdit();
                    GrandTotal();
                }
                LoadProductsFromDatabase();

                guna2DataGridView1.CellEndEdit += guna2DataGridView1_CellEndEdit;
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }
        public void AddItems(string id, string name, string price, Image pımage, string cost)
        {
            try
            {
                var w = new ucProduct()
                {
                    PName = name,
                    pPrice = price,
                    PImage = pımage,
                    PCost = cost,
                    id = Convert.ToInt32(id)
                };
                flowLayoutPanel1.Controls.Add(w);
                w.onSelect += (ss, ee) =>
                {
                    var wdg = (ucProduct)ss;
                    foreach (DataGridViewRow item in guna2DataGridView1.Rows)
                    {
                        if (Convert.ToInt32(item.Cells["dgvproid"].Value) == wdg.id)
                        {
                            item.Cells["dgvqty"].Value = int.Parse(item.Cells["dgvqty"].Value.ToString()) + 1;
                            item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvqty"].Value.ToString()) * int.Parse(item.Cells["dgvPrice"].Value.ToString());
                            GrandTotal();
                            return;
                        }
                    }
                    guna2DataGridView1.Rows.Add(new object[] { 0, wdg.id, wdg.PName, 1, wdg.pPrice, wdg.pPrice, wdg.PCost });
                    GrandTotal();
                };
            }
            catch (Exception ex) { ShowErrorMessage(ex.Message); }
        }
        private void GrandTotal()
        {
            double tot = 0;
            lblTotal.Text = "";
            foreach (DataGridViewRow item in guna2DataGridView1.Rows)
            {
                tot += double.Parse(item.Cells["dgvAmount"].Value.ToString());
            }
            lblTotal.Text = tot.ToString("N2");
        }
        private void LoadProductsFromDatabase()
        {
            string qry = @"Select * From Product";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Byte[] imageArray = (byte[])row["PImage"];
                    byte[] imageByteArray = imageArray;
                    AddItems(row["proID"].ToString(), row["pName"].ToString(), row["pPrice"].ToString(),
                    Image.FromStream(new MemoryStream(imageArray)), row["pCost"].ToString());
                }
            }
        }
        private void ShowErrorMessage(string message)
        {
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            guna2MessageDialog1.Show(message);
        }
        private void ShowSuccessMessage(string message)
        {
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            guna2MessageDialog1.Show(message);
        }
        private void Clearbtn_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Clear();
            datetxt.Value = DateTime.Now;
            cbCustomer.SelectedIndex = 0;
            cbCustomer.SelectedIndex = -1;
            lblTotal.Text = "0.00";
        }
        private void Searctxt_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in flowLayoutPanel1.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PName.ToLower().Contains(Searctxt.Text.Trim().ToLower());
            }
        }
        private void Barcodetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string qry = "Select * from Product where qBarcode like '" + Barcodetxt.Text + "'";
                SqlCommand cmd = new SqlCommand(qry, MainClass.con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    foreach (DataGridViewRow item in guna2DataGridView1.Rows)
                    {
                        if (Convert.ToInt32(item.Cells["dgvproid"].Value) == int.Parse(row["proID"].ToString()))
                        {
                            item.Cells["dgvqty"].Value = int.Parse(item.Cells["dgvqty"].Value.ToString()) + 1;
                            item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvqty"].Value.ToString()) * int.Parse(item.Cells["dgvPrice"].Value.ToString());
                            GrandTotal();
                            Barcodetxt.Text = "";
                            return;
                        }
                    }
                    guna2DataGridView1.Rows.Add(new object[] { 0, row["proID"].ToString(), row["pName"].ToString(), 1, row["pPrice"].ToString(), row["proID"].ToString(), row["pCost"].ToString() });
                }

            }
        }
        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (MainClass.Validation(this) == false)
            {
                ShowErrorMessage("Lütfen Hataları Giderin");
                return;
            }

            if (MainClass.con.State == ConnectionState.Closed)
            {
                MainClass.con.Open();
            }

            using (SqlTransaction transaction = MainClass.con.BeginTransaction())
            {
                try
                {
                    string qry1 = id == 0 ?
                        @"INSERT INTO tblMain VALUES (@date, @type, @supID); SELECT SCOPE_IDENTITY();" :
                        @"UPDATE tblMain SET mdate = @date, mType = @type, mSupID = @supID WHERE MainID = @id";

                    SqlCommand cmd1 = new SqlCommand(qry1, MainClass.con, transaction);
                    cmd1.Parameters.AddWithValue("@id", id);
                    cmd1.Parameters.AddWithValue("@date", datetxt.Value.Date);
                    cmd1.Parameters.AddWithValue("@type", "SAL");
                    cmd1.Parameters.AddWithValue("@supID", Convert.ToInt32(cbCustomer.SelectedValue));

                    if (id == 0)
                        id = Convert.ToInt32(cmd1.ExecuteScalar());
                    else
                        cmd1.ExecuteNonQuery();

                    int record = 0;
                    foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int did = row.Cells["dgvid"].Value == null ? 0 : Convert.ToInt32(row.Cells["dgvid"].Value);
                        string qry2 = did == 0 ?
                            @"INSERT INTO tblDetails (dMainID, productID, qty, price, amount, cost) VALUES (@mID, @proID, @qty, @price, @amount, @cost)" :
                            @"UPDATE tblDetails SET dMainID = @mID, productID = @proID, qty = @qty, price = @price, amount = @amount, cost = @cost WHERE detailID = @id";

                        SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con, transaction);
                        cmd2.Parameters.AddWithValue("@id", did);
                        cmd2.Parameters.AddWithValue("@mID", id);
                        cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["dgvproid"].Value));
                        cmd2.Parameters.AddWithValue("@qty", Convert.ToDecimal(row.Cells["dgvqty"].Value));
                        cmd2.Parameters.AddWithValue("@price", Convert.ToDecimal(row.Cells["dgvCost"].Value));
                        cmd2.Parameters.AddWithValue("@amount", Convert.ToDecimal(row.Cells["dgvAmount"].Value));
                        cmd2.Parameters.AddWithValue("@cost", Convert.ToDecimal(row.Cells["dgvCost"].Value));

                        record += cmd2.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    if (record > 0)
                    {
                        ShowSuccessMessage("Başarıyla Kaydedildi.");
                        ResetForm();
                    }
                }
                catch (Exception ex)
                {
                    try
                    {
                        transaction.Rollback();
                        ShowErrorMessage("Kayıt hatası: " + ex.Message);
                    }
                    catch (Exception rollbackEx)
                    {
                        ShowErrorMessage("Rollback hatası: " + rollbackEx.Message);
                    }
                }
                finally
                {
                    if (MainClass.con.State == ConnectionState.Open)
                    {
                        MainClass.con.Close();
                    }
                }
            }
        }
        private void ResetForm()
        {
            id = 0;
            cusID = 0;
            datetxt.Value = DateTime.Now;
            cbCustomer.SelectedIndex = -1;
            guna2DataGridView1.Rows.Clear();
            lblTotal.Text = "0.00";
        }
        private void LoadForEdit()
        {
            string qry = "Select * from tblDetails inner join product on proID = productID where dMainID = '" + id + "'";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                string did;
                string pid;
                string pname;
                string qty;
                string cost;
                string amt;

                did = row["detailID"].ToString();
                pname = row["pName"].ToString();
                pid = row["proID"].ToString();
                qty = row["qty"].ToString();
                cost = row["price"].ToString();
                amt = row["amount"].ToString();
                cost = row["cost"].ToString();

                guna2DataGridView1.Rows.Add(did, pid, pname, qty, cost, amt, cost);
            }
        }
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;

                if (guna2MessageDialog1.Show("Silmek istediğinizden emin misiniz ?") == DialogResult.Yes)
                {
                    int rowindex = guna2DataGridView1.CurrentCell.RowIndex;
                    guna2DataGridView1.Rows.RemoveAt(rowindex);
                    int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string query = "Delete from tblMain where MainID = " + id + "";
                    string query2 = "Delete from tblDetails where dMainID = " + id + "";
                    Hashtable ht = new Hashtable();
                    MainClass.SQl(query, ht);
                    GrandTotal();
                    
                }
            }
        }

        private void guna2DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Sadece "dgvqty" sütunu için işlem yap
                if (e.RowIndex >= 0 && guna2DataGridView1.Columns[e.ColumnIndex].Name == "dgvqty")
                {
                    DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];

                    // Null ve geçersiz değer kontrolü
                    if (!int.TryParse(row.Cells["dgvqty"].Value?.ToString(), out int qty))
                    {
                        row.Cells["dgvqty"].Value = 1; // Varsayılan değer
                        qty = 1;
                    }

                    // Fiyatı al ve tutarı hesapla
                    decimal price = Convert.ToDecimal(row.Cells["dgvPrice"].Value);
                    row.Cells["dgvAmount"].Value = qty * price;
                    GrandTotal(); // Genel toplamı güncelle
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Hata: " + ex.Message);
            }
        }
    }
}
