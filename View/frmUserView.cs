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
    public partial class frmUserView : SampleView
    {
        public frmUserView()
        {
            InitializeComponent();
            guna2MessageDialog1.Parent = MainForm.Instance;
        }
        public override void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        public override void Addbtn_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmUserAdd());
            LoadData();

        }
        private void LoadData()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvname);
            lb.Items.Add(dgvuserName);
            lb.Items.Add(dgvpass);
            lb.Items.Add(dgvphone);

            string query = @"Select userID, uName, uUserName, uPass, uPhone from users
                                where uName like '%" + Searchtxt.Text + "%' order by userID desc ";
            MainClass.LoadData(query, guna2DataGridView1, lb);
        }

        private void frmUserView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // update
            if ( guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                frmUserAdd frm = new frmUserAdd();
                frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                frm.Nametxt.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvname"].Value);
                frm.Usertxt.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvuserName"].Value);
                frm.Passtxt.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvpass"].Value);
                frm.Phonetxt.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvphone"].Value);
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
                    string query = "Delete from users where userID = " + id + "";
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
