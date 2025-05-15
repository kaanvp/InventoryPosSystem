using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryPosSystem.Model
{
    public partial class frmPurchaseAdd : SampleAdd
    {
        public frmPurchaseAdd()
        {
            InitializeComponent();
            guna2MessageDialog1.Parent = this;
        }

        public int mainID = 0;
        public int supID = 0;
        private void frmPurchaseAdd_Load(object sender, EventArgs e)
        {
            cbProduct.SelectedIndexChanged -= new EventHandler(cbProduct_SelectedIndexChanged);
            string query = "Select proID 'id' , pName 'name' from Product";
            string query2 = "Select supID 'id' , supName 'name' from Supplier";

            MainClass.CBFill(query, cbProduct);
            MainClass.CBFill(query2, cbSupplier);
            if (supID > 0)
            {
                cbSupplier.SelectedValue = supID;
                LoadForEdit();

            }
            cbProduct.SelectedIndexChanged += new EventHandler(cbProduct_SelectedIndexChanged); 
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProduct.SelectedIndex != 1)
            {
                qtytxt.Text = "";
                GetDetails();

            }
        }

        private void GetDetails()
        {
            string query = "Select * from Product where proID = " + Convert.ToInt32(cbProduct.SelectedValue) + "";
            SqlCommand cmd = new SqlCommand(query, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                costxt.Text = dt.Rows[0]["pCost"].ToString();
                Calculate();

            }
        }
        private void qtytxt_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }
        private void Calculate()
        {
            double qty = 0;
            double cost = 0;
            double amt = 0;

            double.TryParse(qtytxt.Text, out qty);
            double.TryParse(costxt.Text, out cost);
            amt = qty * cost;
            amountxt.Text = amt.ToString();
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
                    cbProduct.SelectedValue = Convert.ToInt32(dt.Rows[0]["proID"].ToString());
                    Calculate();
                    Barcodetxt.Text = "";
                }

            }
        }
        
        private void addbtn_Click(object sender, EventArgs e)
        {
            string pid;
            string pname;
            string qty;
            string cost;
            string amt;

            pname = cbProduct.Text;
            pid = cbProduct.SelectedValue.ToString();
            qty = qtytxt.Text;
            cost = costxt.Text;
            amt = amountxt.Text;

            guna2DataGridView1.Rows.Add(0,0,pid,pname,qty,cost,amt);
            cbProduct.SelectedIndex = 0;
            cbProduct.SelectedIndex = -1;
            qtytxt.Text = "";
            costxt.Text = "";
            amountxt.Text = "";
        }

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (sender == null)
            {
                throw new ArgumentNullException(nameof(sender), "Sender parametresi null olamaz.");
            }

            if (sender is Guna.UI2.WinForms.Guna2DataGridView gv)
            {
                int count = 0;

                foreach (DataGridViewRow row in gv.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        count++;
                        row.Cells[0].Value = count;
                    }
                }
            }
            else
            {
                throw new InvalidCastException("Sender parametresi Guna2DataGridView türünde olmalıdır.");
            }
        }

        private void Barcodetxt_TextChanged(object sender, EventArgs e)
        {
            if (Barcodetxt.Text.Length > 0) // boş değilse sorgula
            {
                string qry = "SELECT * FROM Product WHERE qBarcode LIKE '" + Barcodetxt.Text + "'";
                SqlCommand cmd = new SqlCommand(qry, MainClass.con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    cbProduct.SelectedValue = Convert.ToInt32(dt.Rows[0]["proID"].ToString());
                    Calculate();
                    Barcodetxt.Text = ""; // bulunduğunda temizle
                }
            }
        }
        public override void Savebtn_Click(object sender, EventArgs e)
        {
            if (MainClass.Validation(this) == false)
            {
                ShowErrorMessage("Lütfen Hataları Giderin");
                return;
            }

            // Bağlantıyı aç
            if (MainClass.con.State == ConnectionState.Closed)
            {
                MainClass.con.Open();
            }

            using (SqlTransaction transaction = MainClass.con.BeginTransaction())
            {
                try
                {
                    string qry1 = mainID == 0 ?
                        @"INSERT INTO tblMain VALUES (@date, @type, @supID); SELECT SCOPE_IDENTITY();" :
                        @"UPDATE tblMain SET mdate = @date, mType = @type, mSupID = @supID WHERE MainID = @id";

                    SqlCommand cmd1 = new SqlCommand(qry1, MainClass.con, transaction);
                    cmd1.Parameters.AddWithValue("@id", mainID);
                    cmd1.Parameters.AddWithValue("@date", datetxt.Value.Date);
                    cmd1.Parameters.AddWithValue("@type", "PUR");
                    cmd1.Parameters.AddWithValue("@supID", Convert.ToInt32(cbSupplier.SelectedValue));

                    if (mainID == 0)
                        mainID = Convert.ToInt32(cmd1.ExecuteScalar());
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
                        cmd2.Parameters.AddWithValue("@mID", mainID);
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

        private void ResetForm()
        {
            mainID = 0;
            supID = 0;
            datetxt.Value = DateTime.Now;
            cbSupplier.SelectedIndex = -1;
            guna2DataGridView1.Rows.Clear();
        }
        private void LoadForEdit()
        {
            string qry = "Select * from tblDetails inner join product on proID = productID where dMainID = '" + mainID + "'";
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
                pname = row["pname"].ToString();
                pid = row["productID"].ToString();
                qty = row["qty"].ToString();
                cost = row["price"].ToString();
                amt = row["amount"].ToString();


                guna2DataGridView1.Rows.Add(0, did, pid, pname, qty, cost, amt);

            }
        }

    }
}
