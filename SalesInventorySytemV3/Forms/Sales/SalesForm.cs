using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesInventorySytemV3.Models;
using SalesInventorySytemV3.Services.Interfaces;

namespace SalesInventorySytemV3.Forms.Sales
{
    public partial class SalesForm : Form
    {
        private readonly IProductService _productService;
        private readonly ISalesService _salesService;

        public SalesForm(IProductService productService, ISalesService salesService)
        {
            _productService = productService;
            _salesService = salesService;
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            cbProducts.Items.Clear();
            foreach (var p in _productService.GetAllActive().Where(p => p.Stock > 0))
            {
                cbProducts.Items.Add(new ComboBoxItem { Text = $"{p.Name} - ₱{p.Price:F2} (Stock:{p.Stock})", Value = p.Id });
            }
            if (cbProducts.Items.Count > 0) cbProducts.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbProducts.SelectedItem == null) return;
            var item = (ComboBoxItem)cbProducts.SelectedItem;
            int qty = (int)nudQty.Value;
            var product = _productService.GetById((int)item.Value);
            if (product.Stock < qty) { MessageBox.Show("Insufficient stock"); return; }

            var existing = lvItems.Items.Cast<ListViewItem>().FirstOrDefault(i => i.Text == product.Name);
            if (existing != null)
            {
                int cur = int.Parse(existing.SubItems[1].Text);
                existing.SubItems[1].Text = (cur + qty).ToString();
                existing.SubItems[3].Text = $"₱{product.Price * (cur + qty):F2}";
            }
            else
            {
                lvItems.Items.Add(new ListViewItem(new[] { product.Name, qty.ToString(), $"₱{product.Price:F2}", $"₱{product.Price * qty:F2}" }));
            }
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (ListViewItem li in lvItems.Items)
            {
                var t = li.SubItems[3].Text.Replace("₱", "");
                if (decimal.TryParse(t, out decimal v)) total += v;
            }
            lblTotal.Text = $"Total: ₱{total:F2}";
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (lvItems.Items.Count == 0)
            {
                MessageBox.Show("Add items first");
                return;
            }

            var sale = new Sale
            {
                Items = new List<SaleItem>(),
                PaymentMethod = "cash",
                CreatedDate = DateTime.Now  // ✅ CRITICAL LINE
            };

            try
            {
                foreach (ListViewItem li in lvItems.Items)
                {
                    var name = li.SubItems[0].Text;
                    var qty = int.Parse(li.SubItems[1].Text);
                    var p = _productService.GetByName(name);
                    if (p == null) throw new InvalidOperationException("Product not found.");

                    sale.Items.Add(new SaleItem
                    {
                        ProductId = p.Id,
                        Name = p.Name,
                        Quantity = qty,
                        Price = p.Price
                    });
                }

                sale.Total = sale.Items.Sum(i => i.Price * i.Quantity);

                _salesService.Add(sale);

                MessageBox.Show("Sale completed");
                lvItems.Items.Clear();
                UpdateTotal();
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error completing sale: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // helper
        private class ComboBoxItem { public string Text { get; set; } public object Value { get; set; } public override string ToString() => Text; }

        private void SalesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
