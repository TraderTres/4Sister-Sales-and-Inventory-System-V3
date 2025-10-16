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

namespace SalesInventorySytemV3.Forms.Inventory
{
    public partial class InventoryForm : Form
    {
        private readonly IProductService _productService;

        public InventoryForm(IProductService productService)
        {
            _productService = productService;
            InitializeComponent();
            LoadProducts();
        }

        public void LoadProducts()
        {
            dgvProducts.DataSource = null;
            var list = _productService.GetAllActive().Select(p => new
            {
                p.Id,
                p.Name,
                p.Category,
                Stock = $"{p.Stock} {p.Unit}",
                Price = $"₱{p.Price:F2}",
                Expiry = p.Expiry?.ToShortDateString() ?? "N/A",
                Status = p.Active ? "Active" : "Disabled"
            }).ToList();
            dgvProducts.DataSource = list;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var f = new AddProductForm(_productService);
            if (f.ShowDialog() == DialogResult.OK) LoadProducts();
        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0) { MessageBox.Show("Select a product first"); return; }
            string name = dgvProducts.SelectedRows[0].Cells["Name"].Value.ToString();
            var product = _productService.GetByName(name);
            if (product == null) { MessageBox.Show("Product not found"); return; }

            var f = new RestockForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
                product.Stock += f.Quantity;
                _productService.UpdateProduct(product);
                MessageBox.Show("Restocked successfully");
                LoadProducts();
            }
        }
    }
}