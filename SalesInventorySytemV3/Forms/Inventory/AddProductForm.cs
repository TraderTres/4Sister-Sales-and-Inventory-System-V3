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
using System.Xml.Linq;

namespace SalesInventorySytemV3.Forms.Inventory
{
    public partial class AddProductForm : Form
    {
        private readonly IProductService _productService;
        public AddProductForm(IProductService productService)
        {
            _productService = productService;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || !decimal.TryParse(txtPrice.Text, out decimal price) || !int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("Enter valid name, price and stock.");
                return;
            }

            var p = new Product
            {
                Id = _productService.NextId(),
                Name = txtName.Text.Trim(),
                Category = txtCategory.Text.Trim(),
                Brand = txtBrand.Text.Trim(),
                Price = price,
                Stock = stock,
                Unit = txtUnit.Text.Trim(),
                Expiry = chkExpiry.Checked ? (DateTime?)dtExpiry.Value.Date : null,
                Active = true
            };
            _productService.AddProduct(p);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}