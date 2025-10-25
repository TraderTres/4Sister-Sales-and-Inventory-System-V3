using SalesInventorySytemV3.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesInventorySytemV3.Forms.Analytics
{
    public partial class AnalyticsForm : Form
    {
        private readonly IProductService _productService;
        private readonly ISalesService _salesService;
        public AnalyticsForm(IProductService productService, ISalesService salesService)
        {
            _productService = productService;
            _salesService = salesService;
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.time.Text = datetime.ToString();
        }

        private void Analytics_Load(object sender, EventArgs e)
        {
            day.Text = System.DateTime.Now.DayOfWeek.ToString();
        }
    }
}
