using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesInventorySytemV3.Services.Implementations;
using SalesInventorySytemV3.Services.Interfaces;

namespace SalesInventorySytemV3.Forms.Reports
{
    public partial class ReportsForm : Form
    {
        private readonly IProductService _productService;
        private readonly ISalesService _salesService;

        public ReportsForm(IProductService productService, ISalesService salesService)
        {
            _productService = productService;
            _salesService = salesService;
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();

            switch (cbReportType.SelectedItem?.ToString())
            {
                case "Sales (today)":
                    var today = DateTime.Now.Date;
                    var sales = _salesService.GetAll()
                        .Where(s => s.Date.Date == today)
                        .ToList();

                    txtOutput.AppendText($"Today's sales: {sales.Count}\r\n");
                    txtOutput.AppendText($"Total revenue: ₱{sales.Sum(s => s.Total):F2}\r\n\r\n");

                    foreach (var s in sales)
                    {
                        txtOutput.AppendText($"{s.Date:g} - ₱{s.Total:F2}\r\n");
                    }
                    break;

                case "Inventory Value":
                    var totalValue = _productService.GetAllActive()
                        .Sum(p => p.Price * p.Stock);

                    txtOutput.AppendText($"Total inventory value: ₱{totalValue:F2}\r\n");
                    txtOutput.AppendText($"Total products: {_productService.GetAllActive().Count()}\r\n");
                    break;

                case "Product Movement":
                    var movement = _salesService.GetAll()
                        .SelectMany(s => s.Items)
                        .GroupBy(i => i.ProductId)
                        .Select(g => new
                        {
                            Id = g.Key,
                            Name = g.First().Name,
                            Sold = g.Sum(x => x.Quantity),
                            Revenue = g.Sum(x => x.Price * x.Quantity)
                        })
                        .OrderByDescending(x => x.Sold);

                    txtOutput.AppendText("Product movement (best sellers)\r\n\r\n");
                    if (!movement.Any())
                    {
                        txtOutput.AppendText("No sales data available.\r\n");
                    }
                    else
                    {
                        foreach (var m in movement)
                        {
                            txtOutput.AppendText($"{m.Name} - Units Sold: {m.Sold} - Revenue: ₱{m.Revenue:F2}\r\n");
                        }
                    }
                    break;

                default:
                    MessageBox.Show("Please select a report type.");
                    break;
            }
        }
    }
}