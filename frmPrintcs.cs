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
    public partial class frmPrintcs : Sample
    {
        public frmPrintcs()
        {
            InitializeComponent();
        }

        private void frmPrintcs_Load(object sender, EventArgs e)
        {
            btnMax.PerformClick();
        }
    }
}
