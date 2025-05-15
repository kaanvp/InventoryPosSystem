using InventoryPosSystem.Model;
using InventoryPosSystem.View;
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
    public partial class MainForm : Sample
    {
        private static MainForm? _obj;

        public static MainForm Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new MainForm();
                }
                return _obj;
            }

        }

        // Constructor'ı private yap
        private MainForm()
        {
            InitializeComponent();
            guna2MessageDialog1.Parent = this;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _obj = this;
            MaxButton.PerformClick();
            Userlbl.Text = MainClass.USER;
            guna2CirclePictureBox1.Image = MainClass.IMG;

            btnHome.PerformClick();

        }
        public void AddControls(Form F)
        {
            this.CenterPanel.Controls.Clear();
            F.Dock = DockStyle.Fill;
            F.TopLevel = false;
            CenterPanel.Controls.Add(F);
            F.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            AddControls(new frmUserView());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AddControls(new frmCategoryView());
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            AddControls(new frmSupplierView());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            AddControls(new frmCustomerView());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            AddControls(new frmProductView());
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            AddControls(new frmPurchaseView());
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            AddControls(new frmSaleView());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;

            if (guna2MessageDialog1.Show("Çıkmak istediğinizden emin misiniz ?") == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AddControls(new frmDashboard());
        }
    }
}
