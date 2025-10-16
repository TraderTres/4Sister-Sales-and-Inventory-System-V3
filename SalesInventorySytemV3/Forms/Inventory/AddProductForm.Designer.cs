namespace SalesInventorySytemV3.Forms.Inventory
{
    partial class AddProductForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.CheckBox chkExpiry;
        private System.Windows.Forms.DateTimePicker dtExpiry;
        private System.Windows.Forms.Button btnAdd;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.chkExpiry = new System.Windows.Forms.CheckBox();
            this.dtExpiry = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // controls layout (compact)
            // 
            this.lblName.Text = "Product Name"; this.lblName.Location = new System.Drawing.Point(20, 16);
            this.txtName.Location = new System.Drawing.Point(20, 34); this.txtName.Width = 340;
            this.lblCategory.Text = "Category"; this.lblCategory.Location = new System.Drawing.Point(20, 68);
            this.txtCategory.Location = new System.Drawing.Point(20, 86); this.txtCategory.Width = 340;
            this.lblBrand.Text = "Brand"; this.lblBrand.Location = new System.Drawing.Point(20, 120);
            this.txtBrand.Location = new System.Drawing.Point(20, 138); this.txtBrand.Width = 340;
            this.lblPrice.Text = "Price"; this.lblPrice.Location = new System.Drawing.Point(20, 172);
            this.txtPrice.Location = new System.Drawing.Point(20, 190); this.txtPrice.Width = 160;
            this.lblStock.Text = "Initial Stock"; this.lblStock.Location = new System.Drawing.Point(200, 172);
            this.txtStock.Location = new System.Drawing.Point(200, 190); this.txtStock.Width = 160;
            this.lblUnit.Text = "Unit"; this.lblUnit.Location = new System.Drawing.Point(20, 224);
            this.txtUnit.Location = new System.Drawing.Point(20, 242); this.txtUnit.Width = 160; this.txtUnit.Text = "pcs";
            this.chkExpiry.Text = "Has Expiry"; this.chkExpiry.Location = new System.Drawing.Point(200, 224);
            this.dtExpiry.Location = new System.Drawing.Point(200, 242); this.dtExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.btnAdd.Text = "Add Product"; this.btnAdd.Location = new System.Drawing.Point(200, 280); this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            this.ClientSize = new System.Drawing.Size(400, 340);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblName, this.txtName, this.lblCategory, this.txtCategory, this.lblBrand, this.txtBrand, this.lblPrice, this.txtPrice, this.lblStock, this.txtStock, this.lblUnit, this.txtUnit, this.chkExpiry, this.dtExpiry, this.btnAdd });
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Product";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}