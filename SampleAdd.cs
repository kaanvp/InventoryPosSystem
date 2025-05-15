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
    public partial class SampleAdd : Sample
    {
        public SampleAdd()
        {
            InitializeComponent();
            guna2MessageDialog1.Parent = MainForm.Instance;
        }

        public virtual void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void Savebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
