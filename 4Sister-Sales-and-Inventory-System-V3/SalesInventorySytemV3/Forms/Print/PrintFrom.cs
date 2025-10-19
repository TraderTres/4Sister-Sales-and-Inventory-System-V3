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
        public PrintForm(IProductService productService, ISalesService salesService)
        {
            _productService = productService;
            _salesService = salesService;

            InitializeComponent();
        }

        private void SetupPrinting()
        {

        }



        private void btnPrint_Click(object sender, EventArgs e)
        {
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
            
            _sales = _salesService.GetSalesForDate(DateTime.Today).SelectMany(s => s.Items.Select(i => new
            {
                Id = s.Id,
                Product = i.Name,
                i.Quantity,
                Total = $"₱{i.Price * i.Quantity:F2}",
                Date = s.Date.ToShortDateString()
            })).Cast<dynamic>().ToList();
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Graphics g = e.Graphics;
            System.Drawing.Font font = new System.Drawing.Font("Arial", 10);
            System.Drawing.Brush brush = System.Drawing.Brushes.Black;
            int yPos = 50;
            int leftMargin = 50;
            // Header
            g.DrawString("Inventory and Sales Report", new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold), brush, leftMargin, yPos);
            yPos += 40;
            g.DrawString($"Date: {DateTime.Now.ToShortDateString()}", font, brush, leftMargin, yPos);
            yPos += 30;
            // Inventory Section
            g.DrawString("Inventory List:", new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold), brush, leftMargin, yPos);
            yPos += 20;
            g.DrawString("ID | Name | Category | Stock | Price | Expiry | Status", font, brush, leftMargin, yPos);
            yPos += 20;
            // Print inventory items
            int startIndex = _currentPage * _itemsPerPage;
            int endIndex = Math.Min(startIndex + _itemsPerPage, _products.Count);
            for (int i = startIndex; i < endIndex; i++)
            {

                var p = _products[i];
                string line = $"{p.Id} | {p.Name} | {p.Category} | {p.Stock} | {p.Price} | {p.Expiry} | {p.Status}";
                g.DrawString(line, font, brush, leftMargin, yPos);
                yPos += 15;
                if (yPos > e.PageBounds.Height - 50)
                {
                    e.HasMorePages = true;
                    _currentPage++;
                    return;
                }
            }
            // Sales Section
            if (_sales.Count > 0)
            {
                yPos += 20;
                g.DrawString("Sales for Today:", new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold), brush, leftMargin, yPos);
                yPos += 20;
                g.DrawString("ID | Product | Quantity | Total | Date", font, brush, leftMargin, yPos);
                yPos += 20;
                // Print sales items
                int salesStart = Math.Max(0, startIndex - _products.Count);
                int salesEnd = Math.Min(salesStart + (_itemsPerPage - (endIndex - startIndex)), _sales.Count);
                for (int i = salesStart; i < salesEnd; i++)
                {
                    var s = _sales[i];
                    string line = $"{s.Id} | {s.Product} | {s.Quantity} | {s.Total} | {s.Date}";
                    g.DrawString(line, font, brush, leftMargin, yPos);
                    yPos += 15;
                    if (yPos > e.PageBounds.Height - 50)
                    {
                        e.HasMorePages = true;
                        _currentPage++;
                        return;
                    }
                }
                e.HasMorePages = false;
                _currentPage = 0;
            }
        }
    }
}
