﻿using InventoryPosSystem.Model;
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
    public partial class frmSaleView : SampleView
    {
        public frmSaleView()
        {
            InitializeComponent();
        }

        private void frmSaleView_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public override void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        public override void Addbtn_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmSaleAdd());
            LoadData();

        }
        private void LoadData()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvdate);
            lb.Items.Add(dgvCusID);
            lb.Items.Add(dgvCustomer);
            lb.Items.Add(dgvAmount);

            string query = @"select dMainID , mdate , m.mSupID,c.cusName, SUM(d.amount) from tblMain m 
                                inner join tblDetails d on d.dMainID = m.MainID
                                inner join Customer c on c.cusID = m.mSupID
                                where m.mType = 'SAL' and cusName like '%" + Searchtxt.Text + "%'" +
                                " group by dMainID , mdate , m.mSupID,c.cusName ";

            MainClass.LoadData(query, guna2DataGridView1, lb);
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // update
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                frmSaleAdd frm = new frmSaleAdd();
                frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                frm.cusID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvCusID"].Value);

                MainClass.BlurBackground(frm);
                LoadData();
            }
            //delete
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;

                if (guna2MessageDialog1.Show("Silmek istediğinizden emin misiniz ?") == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string query = "Delete from tblMain where MainID = " + id + "";
                    string query2 = "Delete from tblDetails where dMainID = " + id + "";
                    Hashtable ht = new Hashtable();
                    MainClass.SQl(query, ht);
                    if (MainClass.SQl(query2, ht) > 0)
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
