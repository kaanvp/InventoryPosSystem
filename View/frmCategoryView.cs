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
    public partial class frmCategoryView : SampleView
    {
        public frmCategoryView()
        {
            InitializeComponent();
        }

        private void frmCategoryView_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public override void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        public override void Addbtn_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmCategoryAdd());
            LoadData();

        }
        private void LoadData()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvname);

            string query = @"Select * from Category
                                where catName like '%" + Searchtxt.Text + "%' order by catID desc ";
            MainClass.LoadData(query, guna2DataGridView1, lb);
        }

        private void frmUserView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // update
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                frmCategoryAdd frm = new frmCategoryAdd();
                frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                frm.Nametxt.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvname"].Value);

                MainClass.BlurBackground(frm);
                LoadData();
            }
            //delete
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                // confirm before delete
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                if (guna2MessageDialog1.Show("Silmek istediğinizden emin misiniz ?") == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string query = "Delete from Category where catID = " + id + "";
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

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
