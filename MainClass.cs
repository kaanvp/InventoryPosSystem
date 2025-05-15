using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Reflection;
using System.Collections;

namespace InventoryPosSystem
{
    internal class MainClass
    { 

        public static readonly string con_string = "Data Source=DESKTOP-P8VVFDN;Initial Catalog=InventoryPosSystem;Integrated Security=True;Trust Server Certificate=True";
        public static SqlConnection con = new SqlConnection(con_string);


        // MEthod to check user validation
        public static bool IsvalidUser(string user, string pass)
        {
            bool isValid = false;
            string query = @"Select * from users where uUsername = @username and uPass = @pass";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", user);
            cmd.Parameters.AddWithValue("@pass", pass);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                isValid = true;
                USER = dt.Rows[0]["uName"].ToString(); 

                if (dt.Rows[0]["uImage"] != DBNull.Value)
                {
                    Byte[] imageArray = (byte[])dt.Rows[0]["uImage"];
                    IMG = Image.FromStream(new MemoryStream(imageArray)); 
                }
                
            }

            return isValid;
        }
        public static void StopBuffering(Panel ctr, bool doubleBuffer) 
        {
            try 
            {
                typeof(Control).InvokeMember("DoubleBuffered",
                    BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                    null, ctr, new object[] { doubleBuffer });
            }
            catch(Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        // Create property for username

        public static string? user;

        public static string? USER 
        {
            get { return user; } 
            private set { user = value; }
        }


        // for user image
        private static Image? img;

        public static Image IMG
        {
            get
            {
                if (img == null)
                {
                    throw new InvalidOperationException("Resim yüklenmemiş. Lütfen önce bir resim atayın.");
                }
                return img;
            }
            private set { img = value; }
        }

        public static void SetImage(Image image)
        {
            if (image == null)
            {
                throw new ArgumentNullException(nameof(image), "Resim null olamaz.");
            }
            IMG = image;
        }



        // Method for crud operations
        public static int SQl(string query, Hashtable ht) 
        {
            int res = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                foreach(DictionaryEntry item in ht) 
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if (con.State == ConnectionState.Closed) { con.Open(); }
                res = cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
            return res;
        }


        // For loading Data from database
        public static void LoadData(string query, DataGridView gv,ListBox lb) 
        {
            gv.CellFormatting += new DataGridViewCellFormattingEventHandler(gv_CellFormatting);
            try 
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i =0;i < lb.Items.Count;i++) 
                {
                    string colName1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colName1].DataPropertyName = dt.Columns[i].ToString();
                }
                gv.DataSource = dt;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }
        private static void gv_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
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
        public static void BlurBackground(Form Model) 
        {
            Form Background = new Form();
            using (Model) 
            {
                Background.StartPosition = FormStartPosition.Manual;
                Background.FormBorderStyle = FormBorderStyle.None;
                Background.Opacity = 0.5d;
                Background.BackColor = Color.Black;
                Background.Size = MainForm.Instance.Size;
                Background.Location = MainForm.Instance.Location;
                Background.ShowInTaskbar = false;
                Background.Show();
                Model.Owner = Background;
                Model.ShowDialog(Background);
                Background.Dispose();  
            }
        }
        // for cb fill
        public static void CBFill(string query, ComboBox cb) 
        {
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cb.DisplayMember = "name";
            cb.ValueMember = "id";
            cb.DataSource = dt;
            cb.SelectedIndex = -1; 
        }
        public static bool Validation(Form F)
        {
            bool isValid = false;
            int count = 0;

            foreach (Control c in F.Controls)
            {
                // using tag of the control to check if we want to validate it or  not
                if (Convert.ToString(c.Tag) != "" && Convert.ToString(c.Tag) != null)
                {
                    // for textbox
                    if (c is Guna.UI2.WinForms.Guna2TextBox)
                    {
                        Guna.UI2.WinForms.Guna2TextBox t = (Guna.UI2.WinForms.Guna2TextBox)c;
                        if (t.Text.Trim() == "")
                        {
                            t.BorderColor = Color.Red;
                            t.FocusedState.BorderColor = Color.Red;
                            t.HoverState.BorderColor = Color.Red;
                            count++;
                        }
                        else
                        {

                            t.BorderColor = Color.FromArgb(213, 218, 223);
                            t.FocusedState.BorderColor = Color.FromArgb(21, 76, 121);
                            t.HoverState.BorderColor = Color.FromArgb(21, 76, 121);
                        }
                    }
                    // for combobox
                    if (c is Guna.UI2.WinForms.Guna2ComboBox)
                    {
                        Guna.UI2.WinForms.Guna2ComboBox t = (Guna.UI2.WinForms.Guna2ComboBox)c;
                        if (t.SelectedIndex == -1)
                        {
                            t.BorderColor = Color.Red;
                            t.FocusedState.BorderColor = Color.Red;
                            t.HoverState.BorderColor = Color.Red;
                            count++;
                        }
                        else
                        {

                            t.BorderColor = Color.FromArgb(213, 218, 223);
                            t.FocusedState.BorderColor = Color.FromArgb(21, 76, 121);
                            t.HoverState.BorderColor = Color.FromArgb(21, 76, 121);
                        }
                    }
                }
                if (count == 0)
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                }
            }
            return isValid;
        }
        

    }

}
