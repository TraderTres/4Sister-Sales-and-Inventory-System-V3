using SalesInventorySytemV3.Forms.Print;
using SalesInventorySytemV3.Models;
using SalesInventorySytemV3.Services.Implementations;
using SalesInventorySytemV3.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesInventorySytemV3.Forms.Print
{
    public partial class PrintForm : Form
    {
        private readonly IProductService _productService;
        private readonly ISalesService _salesService;

        private List<dynamic> _products;
        private List<dynamic> _sales;
        private int _currentPage = 0;
        private int _itemsPerPage = 25;
        private string _printMode = "Inventory";

        public PrintForm(IProductService productService, ISalesService salesService)
        {
            _productService = productService;
            _salesService = salesService;

            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // determine which mode to print
            if (rbSales.Checked)
                _printMode = "Sales";
            else if (rbBoth.Checked)
                _printMode = "Both";
            else
                _printMode = "Inventory";

            // get date range if checked
            DateTime startDate = DateTime.Today;
            DateTime endDate = DateTime.Today;
            if (chkDateRange.Checked)
            {
                startDate = dtpStartDate.Value.Date;
                endDate = dtpEndDate.Value.Date;
            }

            // load data based on selected options
            _products = _productService.GetAllActive().Select(p => new
            {
                p.Id,
                p.Name,
                p.Category,
                Stock = $"{p.Stock} {p.Unit}",
                Price = $"₱{p.Price:F2}",
                Expiry = p.Expiry?.ToShortDateString() ?? "N/A",
                Status = p.Active ? "Active" : "Disabled"
            }).Cast<dynamic>().ToList();

            _sales = _salesService.GetSalesBetween(startDate, endDate)
                .SelectMany(s => s.Items.Select(i => new
                {
                    Id = s.Id,
                    Product = i.Name,
                    i.Quantity,
                    Total = $"₱{i.Price * i.Quantity:F2}",
                    Date = s.CreatedDate.ToShortDateString()
                })).Cast<dynamic>().ToList();

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 10);
            Brush brush = Brushes.Black;
            int yPos = 50;
            int leftMargin = 50;

            // Header
            g.DrawString("Sales and Inventory Report", new Font("Arial", 14, FontStyle.Bold), brush, leftMargin, yPos);
            yPos += 40;
            g.DrawString($"Date Printed: {DateTime.Now.ToShortDateString()}", font, brush, leftMargin, yPos);
            yPos += 30;

            // Inventory Section
            if (_printMode == "Inventory" || _printMode == "Both")
            {
                g.DrawString("Inventory List:", new Font("Arial", 12, FontStyle.Bold), brush, leftMargin, yPos);
                yPos += 20;
                g.DrawString("ID | Name | Category | Stock | Price | Expiry | Status", font, brush, leftMargin, yPos);
                yPos += 20;

                foreach (var p in _products)
                {
                    string line = $"{p.Id} | {p.Name} | {p.Category} | {p.Stock} | {p.Price} | {p.Expiry} | {p.Status}";
                    g.DrawString(line, font, brush, leftMargin, yPos);
                    yPos += 15;
                    if (yPos > e.MarginBounds.Bottom - 50)
                    {
                        e.HasMorePages = true;
                        return;
                    }
                }

                yPos += 30;
            }

            // Sales Section
            if (_printMode == "Sales" || _printMode == "Both")
            {
                g.DrawString("Sales Report:", new Font("Arial", 12, FontStyle.Bold), brush, leftMargin, yPos);
                yPos += 20;
                g.DrawString("ID | Product | Quantity | Total | Date", font, brush, leftMargin, yPos);
                yPos += 20;

                foreach (var s in _sales)
                {
                    string line = $"{s.Id} | {s.Product} | {s.Quantity} | {s.Total} | {s.Date}";
                    g.DrawString(line, font, brush, leftMargin, yPos);
                    yPos += 15;
                    if (yPos > e.MarginBounds.Bottom - 50)
                    {
                        e.HasMorePages = true;
                        return;
                    }
                }
            }

            e.HasMorePages = false;
        }
    }
}