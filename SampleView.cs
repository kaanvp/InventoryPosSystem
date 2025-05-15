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
    public partial class SampleView : Sample
    {
        public SampleView()
        {
            InitializeComponent();
            guna2MessageDialog1.Parent = MainForm.Instance;
        }

        public virtual void Searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        public virtual void Addbtn_Click(object sender, EventArgs e)
        {

        }
        
    }
}
