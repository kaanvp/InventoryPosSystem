using System;
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
    public partial class ucProduct : UserControl
    {
        public event EventHandler onSelect = null;
        public ucProduct()
        {
            InitializeComponent();
        }

        private void Pictxt_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
        public int id { get; set; }
        public string? PCost { get; set; }
        public string? pPrice
        {
            get { return Pricelbl.Text; }
            set { Pricelbl.Text = value; }
        }
        public string? PName 
        {
            get { return Nametxt.Text; }
            set { Nametxt.Text = value;}
        }
        public Image? PImage
        {
            get { return Pictxt.Image; }
            set { Pictxt.Image = value;}
        }
    }
}
