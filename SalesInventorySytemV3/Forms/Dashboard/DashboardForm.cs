using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesInventorySytemV3.Services.Interfaces;

namespace SalesInventorySytemV3.Forms.Dashboard
{
    public partial class DashboardForm : Form
    {
        private readonly IProductService _productService;
        private readonly ISalesService _salesService;

        public DashboardForm(IProductService productService, ISalesService salesService)
        {
            _productService = productService;
            _salesService = salesService;
            InitializeComponent();
            LoadDashboard();
        }

        public void LoadDashboard()
        {
            var today = DateTime.Now.Date;
            var todaySales = _salesService.GetAll().Where(s => s.Date.Date == today).ToList();
            var totalToday = todaySales.Sum(s => s.Total);
            var lowStock = _productService.GetAllActive().Count(p => p.Stock <= 10 && p.Stock > 0);
            var outOfStock = _productService.GetAllActive().Count(p => p.Stock == 0);

            lblTodaySales.Text = $"₱{totalToday:F2}";
            lblTotalProducts.Text = _productService.GetAllActive().Count().ToString();
            lblLowStock.Text = (lowStock + outOfStock).ToString();
            lblTodayOrders.Text = todaySales.Count.ToString();

            lvRecent.Items.Clear();
            var recent = _salesService.GetAll().OrderByDescending(s => s.Date).Take(5).ToList();
            if (!recent.Any()) lvRecent.Items.Add(new ListViewItem(new[] { "-", "No transactions yet", "-" }));
            else
            {
                foreach (var s in recent)
                {
                    var itemsText = string.Join(", ", s.Items.Select(i => $"{i.Name}({i.Quantity})"));
                    lvRecent.Items.Add(new ListViewItem(new[] { s.Date.ToString("g"), itemsText, $"₱{s.Total:F2}" }));
                }
            }
        }
    }
}