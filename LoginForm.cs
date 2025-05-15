using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryPosSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (MainClass.IsvalidUser(Usertxt.Text, Passtxt.Text))
            {
                MainForm frm = MainForm.Instance;
                frm.Show();
                this.Hide();
            }
            else
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog1.Show("Geçersiz kullanıcı adı ve şifre");
            }
        }

        private void guna2TextBox1_IconRightClick(object sender, EventArgs e)
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

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Passtxt.IconRight = ımageList1.Images[0];

        }

        private void Passtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button1.PerformClick();
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
