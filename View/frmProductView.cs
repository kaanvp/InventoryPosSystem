using Guna.UI2.WinForms;
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
    public partial class frmProductView : SampleView
    {
        public frmProductView()
        {
            InitializeComponent();
        }

        private void frmProductView_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public override void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        public override void Addbtn_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmProductAdd());
            LoadData();

        }
        private void LoadData()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid1);
            lb.Items.Add(dgvName1);
            lb.Items.Add(dgvcatID);
            lb.Items.Add(dgvCategory);
            lb.Items.Add(dgvbarcode);
            lb.Items.Add(dgvcost);
            lb.Items.Add(dgvSale);

            string query = @"Select proID, pName, pCatID, catName, qBarcode,pCost,pPrice from 
                        Product inner join Category on catID=pCatID 
                        where pName like '%" + Searchtxt.Text + "%' order by proID desc ";
            MainClass.LoadData(query, guna2DataGridView2, lb);
        }

        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // update
            if (guna2DataGridView2.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                frmProductAdd frm = new frmProductAdd();
                frm.id = Convert.ToInt32(guna2DataGridView2.CurrentRow.Cells["dgvid1"].Value);
                frm.catID = Convert.ToInt32(guna2DataGridView2.CurrentRow.Cells["dgvcatID"].Value);
                frm.Nametxt.Text = Convert.ToString(guna2DataGridView2.CurrentRow.Cells["dgvName1"].Value);
                frm.Barcodetxt.Text = Convert.ToString(guna2DataGridView2.CurrentRow.Cells["dgvbarcode"].Value);
                frm.Costxt.Text = Convert.ToString(guna2DataGridView2.CurrentRow.Cells["dgvcost"].Value);
                frm.Selltxt.Text = Convert.ToString(guna2DataGridView2.CurrentRow.Cells["dgvSale"].Value);
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
                    int id = Convert.ToInt32(guna2DataGridView2.CurrentRow.Cells["dgvid"].Value);
                    string query = "Delete from Product where proID = " + id + "";
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
