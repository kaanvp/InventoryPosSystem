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

namespace InventoryPosSystem.Model
{
    public partial class frmCustomerAdd : SampleAdd
    {
        public frmCustomerAdd()
        {
            InitializeComponent();
            guna2MessageDialog1.Parent = this;
        }
        public int id = 0;
        public override void Savebtn_Click(object sender, EventArgs e)
        {

            // before save we need validation
            if (MainClass.Validation(this) == false)
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog1.Show("Lütfen Hataları giderin");
                return;
            }
            else
            {
                string query = "";

                if (id == 0) //Insert
                {
                    query = @"Insert into Customer values(@name,@phone,@email)";
                }
                else //update
                {
                    query = @"UPDATE Customer SET cusName = @name,
                                                cusPhone = @phone,
                                                cusEmail = @email
                                                WHERE cusID = @id";
                }

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@name", Nametxt.Text);
                ht.Add("@phone", Phonetxt.Text);
                ht.Add("@email", Emailtxt.Text);

                if (MainClass.SQl(query, ht) > 0)
                {
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    guna2MessageDialog1.Show("Veri Başarıyla Kaydedildi");
                    id = 0;
                    Nametxt.Text = "";
                    Phonetxt.Text = "";
                    Emailtxt.Text = "";
                    Nametxt.Focus();
                }
            }
        }
    }
}
