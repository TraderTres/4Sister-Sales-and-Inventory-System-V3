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
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(18, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(56, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sales";
            // 
            // cbProducts
            // 
            this.cbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(24, 131);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(420, 26);
            this.cbProducts.TabIndex = 1;
            // 
            // nudQty
            // 
            this.nudQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQty.Location = new System.Drawing.Point(464, 133);
            this.nudQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(100, 24);
            this.nudQty.TabIndex = 2;
            this.nudQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(584, 129);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
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
            this.lvItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvItems.HideSelection = false;
            this.lvItems.Location = new System.Drawing.Point(24, 172);
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(1636, 619);
            this.lvItems.TabIndex = 4;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            // 
            // chProduct
            // 
            this.chProduct.Text = "Product";
            this.chProduct.Width = 859;
            // 
            // chQty
            // 
            this.chQty.Text = "Qty";
            this.chQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chQty.Width = 190;
            // 
            // chPrice
            // 
            this.chPrice.Text = "Price";
            this.chPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPrice.Width = 236;
            // 
            // chTotal
            // 
            this.chTotal.Text = "Total";
            this.chTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chTotal.Width = 348;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(21, 807);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(87, 18);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total: ₱0.00";
            // 
            // btnComplete
            // 
            this.btnComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.Location = new System.Drawing.Point(1524, 807);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(136, 28);
            this.btnComplete.TabIndex = 6;
            this.btnComplete.Text = "Complete Sale";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1689, 84);
            this.panel1.TabIndex = 7;
            // 
            // SalesForm
            // 
            this.ClientSize = new System.Drawing.Size(1689, 888);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lvItems);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nudQty);
            this.Controls.Add(this.cbProducts);
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panel1;
    }
}