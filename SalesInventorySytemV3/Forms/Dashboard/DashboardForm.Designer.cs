namespace SalesInventorySytemV3.Forms.Dashboard
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTodaySalesLabel;
        private System.Windows.Forms.Label lblTodaySales;
        private System.Windows.Forms.Label lblTotalProducts;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.Label lblTodayOrders;
        private System.Windows.Forms.ListView lvRecent;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.ColumnHeader chItems;
        private System.Windows.Forms.ColumnHeader chTotal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTodaySalesLabel = new System.Windows.Forms.Label();
            this.lblTodaySales = new System.Windows.Forms.Label();
            this.lblTotalProducts = new System.Windows.Forms.Label();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.lblTodayOrders = new System.Windows.Forms.Label();
            this.lvRecent = new System.Windows.Forms.ListView();
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chItems = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(98, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dashboard";
            // 
            // lblTodaySalesLabel
            // 
            this.lblTodaySalesLabel.AutoSize = true;
            this.lblTodaySalesLabel.Location = new System.Drawing.Point(20, 60);
            this.lblTodaySalesLabel.Name = "lblTodaySalesLabel";
            this.lblTodaySalesLabel.Size = new System.Drawing.Size(74, 13);
            this.lblTodaySalesLabel.TabIndex = 1;
            this.lblTodaySalesLabel.Text = "Today's Sales";
            // 
            // lblTodaySales
            // 
            this.lblTodaySales.AutoSize = true;
            this.lblTodaySales.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTodaySales.Location = new System.Drawing.Point(20, 80);
            this.lblTodaySales.Name = "lblTodaySales";
            this.lblTodaySales.Size = new System.Drawing.Size(34, 19);
            this.lblTodaySales.TabIndex = 2;
            this.lblTodaySales.Text = "₱0.0";
            // 
            // lblTotalProducts
            // 
            this.lblTotalProducts.AutoSize = true;
            this.lblTotalProducts.Location = new System.Drawing.Point(220, 80);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.Size = new System.Drawing.Size(13, 13);
            this.lblTotalProducts.TabIndex = 3;
            this.lblTotalProducts.Text = "0";
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Location = new System.Drawing.Point(420, 80);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(13, 13);
            this.lblLowStock.TabIndex = 4;
            this.lblLowStock.Text = "0";
            // 
            // lblTodayOrders
            // 
            this.lblTodayOrders.AutoSize = true;
            this.lblTodayOrders.Location = new System.Drawing.Point(620, 80);
            this.lblTodayOrders.Name = "lblTodayOrders";
            this.lblTodayOrders.Size = new System.Drawing.Size(13, 13);
            this.lblTodayOrders.TabIndex = 5;
            this.lblTodayOrders.Text = "0";
            // 
            // lvRecent
            // 
            this.lvRecent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTime,
            this.chItems,
            this.chTotal});
            this.lvRecent.Location = new System.Drawing.Point(20, 120);
            this.lvRecent.Name = "lvRecent";
            this.lvRecent.Size = new System.Drawing.Size(820, 320);
            this.lvRecent.TabIndex = 6;
            this.lvRecent.UseCompatibleStateImageBehavior = false;
            this.lvRecent.View = System.Windows.Forms.View.Details;
            // 
            // chTime
            // 
            this.chTime.Text = "Time";
            this.chTime.Width = 200;
            // 
            // chItems
            // 
            this.chItems.Text = "Items";
            this.chItems.Width = 520;
            // 
            // chTotal
            // 
            this.chTotal.Text = "Total";
            this.chTotal.Width = 100;
            // 
            // DashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(900, 480);
            this.Controls.Add(this.lvRecent);
            this.Controls.Add(this.lblTodayOrders);
            this.Controls.Add(this.lblLowStock);
            this.Controls.Add(this.lblTotalProducts);
            this.Controls.Add(this.lblTodaySales);
            this.Controls.Add(this.lblTodaySalesLabel);
            this.Controls.Add(this.lblTitle);
            this.Name = "DashboardForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}