namespace SalesInventorySytemV3.Forms.Sales
{
    partial class SalesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.ColumnHeader chProduct;
        private System.Windows.Forms.ColumnHeader chQty;
        private System.Windows.Forms.ColumnHeader chPrice;
        private System.Windows.Forms.ColumnHeader chTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnComplete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvItems = new System.Windows.Forms.ListView();
            this.chProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(59, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sales";
            // 
            // cbProducts
            // 
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(20, 60);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(420, 21);
            this.cbProducts.TabIndex = 1;
            // 
            // nudQty
            // 
            this.nudQty.Location = new System.Drawing.Point(460, 60);
            this.nudQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(100, 20);
            this.nudQty.TabIndex = 2;
            this.nudQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(580, 58);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 24);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvItems
            // 
            this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProduct,
            this.chQty,
            this.chPrice,
            this.chTotal});
            this.lvItems.Location = new System.Drawing.Point(20, 100);
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(760, 320);
            this.lvItems.TabIndex = 4;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            // 
            // chProduct
            // 
            this.chProduct.Text = "Product";
            this.chProduct.Width = 400;
            // 
            // chQty
            // 
            this.chQty.Text = "Qty";
            this.chQty.Width = 80;
            // 
            // chPrice
            // 
            this.chPrice.Text = "Price";
            this.chPrice.Width = 120;
            // 
            // chTotal
            // 
            this.chTotal.Text = "Total";
            this.chTotal.Width = 120;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(20, 430);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(83, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total: ₱0.00";
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(660, 426);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(120, 24);
            this.btnComplete.TabIndex = 6;
            this.btnComplete.Text = "Complete Sale";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // SalesForm
            // 
            this.ClientSize = new System.Drawing.Size(820, 470);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lvItems);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nudQty);
            this.Controls.Add(this.cbProducts);
            this.Controls.Add(this.lblTitle);
            this.Name = "SalesForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}