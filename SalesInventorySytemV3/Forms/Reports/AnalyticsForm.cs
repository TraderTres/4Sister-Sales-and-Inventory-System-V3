using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SalesInventorySytemV3.Services.Interfaces;

namespace SalesInventorySytemV3.Forms.Reports
{
    public partial class AnalyticsForm : Form
    {
        private readonly ISalesService _salesService;
        private readonly IProductService _productService;

        public AnalyticsForm(ISalesService salesService, IProductService productService)
        {
            _salesService = salesService;
            _productService = productService;
            InitializeComponent();
        }

        private void AnalyticsForm_Load(object sender, EventArgs e)
        {
            // Initialize default date range (past 30 days)
            dtpEnd.Value = DateTime.Today;
            dtpStart.Value = DateTime.Today.AddDays(-30);
            RefreshCharts();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshCharts();
        }

        private void RefreshCharts()
        {
            DateTime start = dtpStart.Value.Date;
            DateTime end = dtpEnd.Value.Date;

            // 1️⃣ SALES OVER TIME
            var salesSummary = _salesService.GetSalesSummaryByDate(start, end).ToList();

            var sSeries = chartSales.Series["SalesSeries"];
            sSeries.Points.Clear();

            foreach (var item in salesSummary)
            {
                int index = sSeries.Points.AddXY(item.Date, (double)item.Total);
                DataPoint dp = sSeries.Points[index];
                dp.ToolTip = $"{item.Date:MMM dd, yyyy}: ₱{item.Total:N2}";
            }

            if (chartSales.ChartAreas.Count > 0)
            {
                chartSales.ChartAreas[0].AxisX.LabelStyle.Format = "MM-dd";
                chartSales.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
                chartSales.ChartAreas[0].RecalculateAxesScale();
            }

            // 2️⃣ TOP PRODUCTS
            chartTopProducts.Series.Clear();
            var topSeries = new Series("TopProductsSeries")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };
            chartTopProducts.Series.Add(topSeries);

            var topProducts = _salesService.GetTopProducts(start, end, 10).ToList();
            foreach (var t in topProducts)
            {
                int index = topSeries.Points.AddY((double)t.TotalSold);
                DataPoint dp = topSeries.Points[index];
                dp.AxisLabel = t.ProductName;
                dp.ToolTip = $"{t.ProductName}: ₱{t.TotalSold:N2}";
            }

            if (chartTopProducts.ChartAreas.Count > 0)
            {
                chartTopProducts.ChartAreas[0].RecalculateAxesScale();
            }

            // 3️⃣ INVENTORY LEVELS
            chartInventory.Series.Clear();
            var invSeries = new Series("InventorySeries")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true
            };
            chartInventory.Series.Add(invSeries);

            var inventory = _productService.GetInventoryLevels().ToList();
            foreach (var inv in inventory.OrderByDescending(x => x.Stock).Take(10))
            {
                int index = invSeries.Points.AddY(inv.Stock);
                DataPoint dp = invSeries.Points[index];
                dp.LegendText = inv.ProductName;
                dp.ToolTip = $"{inv.ProductName}: {inv.Stock} pcs";
            }

            if (chartInventory.ChartAreas.Count > 0)
            {
                chartInventory.ChartAreas[0].Area3DStyle.Enable3D = true;
                chartInventory.ChartAreas[0].Area3DStyle.Inclination = 30;
            }
        }
    }
}