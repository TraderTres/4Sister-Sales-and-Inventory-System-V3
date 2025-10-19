using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesInventorySytemV3.Forms.Inventory
{
    public partial class RestockForm : Form
    {
        public int Quantity { get; private set; }
        public RestockForm() { InitializeComponent(); }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Quantity = (int)nudQty.Value;
            this.DialogResult = DialogResult.OK;
        }
        private void btnCancel_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.Cancel;
    }
}