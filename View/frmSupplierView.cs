using InventoryPosSystem.Model;
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

namespace InventoryPosSystem.View
{
    public partial class frmSupplierView : SampleView
    {
        public frmSupplierView()
        {
            InitializeComponent();
        }

        private void frmSupplierView_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public override void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        public override void Addbtn_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmSupplierAdd());
            LoadData();

        }
        private void LoadData()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid1);
            lb.Items.Add(dgvName1);
            lb.Items.Add(dgvPhone1);
            lb.Items.Add(dgvemail1);

            string query = @"Select * from Supplier
                                where supName like '%" + Searchtxt.Text + "%' order by supID desc ";
            MainClass.LoadData(query, guna2DataGridView2, lb);
        }

        private void frmUserView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // update
            if (guna2DataGridView2.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                frmSupplierAdd frm = new frmSupplierAdd();
                frm.id = Convert.ToInt32(guna2DataGridView2.CurrentRow.Cells["dgvid1"].Value);
                frm.Nametxt.Text = Convert.ToString(guna2DataGridView2.CurrentRow.Cells["dgvName1"].Value);
                frm.Phonetxt.Text = Convert.ToString(guna2DataGridView2.CurrentRow.Cells["dgvPhone1"].Value);
                frm.Emailtxt.Text = Convert.ToString(guna2DataGridView2.CurrentRow.Cells["dgvemail1"].Value);

                MainClass.BlurBackground(frm);
                LoadData();
            }
            //delete
            if (guna2DataGridView2.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;

                if (guna2MessageDialog1.Show("Silmek istediğinizden emin misiniz ?") == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(guna2DataGridView2.CurrentRow.Cells["dgvid1"].Value);
                    string query = "Delete from Supplier where supID = " + id + "";
                    Hashtable ht = new Hashtable();
                    if (MainClass.SQl(query, ht) > 0)
                    {
                        guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                        guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                        guna2MessageDialog1.Show("Silme işlemi Başarılı");
                        LoadData();
                    }
                }


            }
        }
    }
}
