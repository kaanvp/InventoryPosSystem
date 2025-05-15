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
    public partial class frmCategoryAdd : SampleAdd
    {
        public frmCategoryAdd()
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
                    query = @"Insert into Category values(@name)";
                }
                else //update
                {
                    query = @"UPDATE Category SET catName = @name
                                                WHERE catID = @id";
                }

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@name", Nametxt.Text);

                if (MainClass.SQl(query, ht) > 0)
                {
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    guna2MessageDialog1.Show("Veri Başarıyla Kaydedildi");
                    id = 0;
                    Nametxt.Text = "";
                    Nametxt.Focus();
                }
            }
        }
    }
}
