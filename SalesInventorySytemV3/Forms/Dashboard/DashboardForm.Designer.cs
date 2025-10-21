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
<<<<<<< HEAD
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
=======
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
>>>>>>> b84597ba2fecdfbc5f6fc4f4bb9b8913e349d8f8
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.lblTitle.Location = new System.Drawing.Point(18, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(109, 25);
=======
            this.lblTitle.Location = new System.Drawing.Point(18, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(138, 32);
>>>>>>> b84597ba2fecdfbc5f6fc4f4bb9b8913e349d8f8
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dashboard";
            // 
            // lblTodaySalesLabel
            // 
            this.lblTodaySalesLabel.AutoSize = true;
            this.lblTodaySalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaySalesLabel.ForeColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.lblTodaySalesLabel.Location = new System.Drawing.Point(21, 111);
            this.lblTodaySalesLabel.Name = "lblTodaySalesLabel";
            this.lblTodaySalesLabel.Size = new System.Drawing.Size(114, 18);
            this.lblTodaySalesLabel.TabIndex = 1;
            this.lblTodaySalesLabel.Text = "Today\'s Sales";
=======
            this.lblTodaySalesLabel.Location = new System.Drawing.Point(21, 74);
            this.lblTodaySalesLabel.Name = "lblTodaySalesLabel";
            this.lblTodaySalesLabel.Size = new System.Drawing.Size(146, 24);
            this.lblTodaySalesLabel.TabIndex = 1;
            this.lblTodaySalesLabel.Text = "Today\'s Sales:";
>>>>>>> b84597ba2fecdfbc5f6fc4f4bb9b8913e349d8f8
            // 
            // lblTodaySales
            // 
            this.lblTodaySales.AutoSize = true;
<<<<<<< HEAD
            this.lblTodaySales.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaySales.ForeColor = System.Drawing.Color.Black;
            this.lblTodaySales.Location = new System.Drawing.Point(21, 137);
            this.lblTodaySales.Name = "lblTodaySales";
            this.lblTodaySales.Size = new System.Drawing.Size(43, 20);
=======
            this.lblTodaySales.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTodaySales.ForeColor = System.Drawing.Color.Black;
            this.lblTodaySales.Location = new System.Drawing.Point(21, 100);
            this.lblTodaySales.Name = "lblTodaySales";
            this.lblTodaySales.Size = new System.Drawing.Size(46, 23);
>>>>>>> b84597ba2fecdfbc5f6fc4f4bb9b8913e349d8f8
            this.lblTodaySales.TabIndex = 2;
            this.lblTodaySales.Text = "₱0.0";
            // 
            // lblTotalProducts
            // 
            this.lblTotalProducts.AutoSize = true;
<<<<<<< HEAD
            this.lblTotalProducts.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProducts.ForeColor = System.Drawing.Color.Black;
            this.lblTotalProducts.Location = new System.Drawing.Point(221, 137);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.Size = new System.Drawing.Size(18, 20);
=======
            this.lblTotalProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProducts.ForeColor = System.Drawing.Color.Black;
            this.lblTotalProducts.Location = new System.Drawing.Point(221, 100);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.Size = new System.Drawing.Size(20, 24);
>>>>>>> b84597ba2fecdfbc5f6fc4f4bb9b8913e349d8f8
            this.lblTotalProducts.TabIndex = 3;
            this.lblTotalProducts.Text = "0";
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
<<<<<<< HEAD
            this.lblLowStock.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStock.ForeColor = System.Drawing.Color.Black;
            this.lblLowStock.Location = new System.Drawing.Point(421, 137);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(18, 20);
=======
            this.lblLowStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStock.ForeColor = System.Drawing.Color.Black;
            this.lblLowStock.Location = new System.Drawing.Point(421, 100);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(20, 24);
>>>>>>> b84597ba2fecdfbc5f6fc4f4bb9b8913e349d8f8
            this.lblLowStock.TabIndex = 4;
            this.lblLowStock.Text = "0";
            // 
            // lblTodayOrders
            // 
            this.lblTodayOrders.AutoSize = true;
<<<<<<< HEAD
            this.lblTodayOrders.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayOrders.ForeColor = System.Drawing.Color.Black;
            this.lblTodayOrders.Location = new System.Drawing.Point(621, 137);
            this.lblTodayOrders.Name = "lblTodayOrders";
            this.lblTodayOrders.Size = new System.Drawing.Size(18, 20);
=======
            this.lblTodayOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayOrders.ForeColor = System.Drawing.Color.Black;
            this.lblTodayOrders.Location = new System.Drawing.Point(621, 100);
            this.lblTodayOrders.Name = "lblTodayOrders";
            this.lblTodayOrders.Size = new System.Drawing.Size(20, 24);
>>>>>>> b84597ba2fecdfbc5f6fc4f4bb9b8913e349d8f8
            this.lblTodayOrders.TabIndex = 5;
            this.lblTodayOrders.Text = "0";
            // 
            // lvRecent
            // 
            this.lvRecent.BackColor = System.Drawing.Color.White;
            this.lvRecent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTime,
            this.chItems,
            this.chTotal});
            this.lvRecent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvRecent.ForeColor = System.Drawing.Color.Black;
            this.lvRecent.HideSelection = false;
            this.lvRecent.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
<<<<<<< HEAD
            listViewItem2});
            this.lvRecent.Location = new System.Drawing.Point(12, 175);
            this.lvRecent.Name = "lvRecent";
            this.lvRecent.Size = new System.Drawing.Size(1644, 619);
=======
            listViewItem1});
            this.lvRecent.Location = new System.Drawing.Point(12, 138);
            this.lvRecent.Name = "lvRecent";
            this.lvRecent.Size = new System.Drawing.Size(1102, 482);
>>>>>>> b84597ba2fecdfbc5f6fc4f4bb9b8913e349d8f8
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
            this.chItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
<<<<<<< HEAD
            this.chItems.Width = 1109;
=======
            this.chItems.Width = 577;
>>>>>>> b84597ba2fecdfbc5f6fc4f4bb9b8913e349d8f8
            // 
            // chTotal
            // 
            this.chTotal.Text = "Total";
            this.chTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
<<<<<<< HEAD
            this.chTotal.Width = 331;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1689, 84);
=======
            this.chTotal.Width = 320;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 61);
>>>>>>> b84597ba2fecdfbc5f6fc4f4bb9b8913e349d8f8
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.label1.Location = new System.Drawing.Point(172, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
=======
            this.label1.Location = new System.Drawing.Point(221, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
>>>>>>> b84597ba2fecdfbc5f6fc4f4bb9b8913e349d8f8
            this.label1.TabIndex = 8;
            this.label1.Text = "Total Products";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.label2.Location = new System.Drawing.Point(383, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
=======
            this.label2.Location = new System.Drawing.Point(421, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
>>>>>>> b84597ba2fecdfbc5f6fc4f4bb9b8913e349d8f8
            this.label2.TabIndex = 9;
            this.label2.Text = "Low Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.label3.Location = new System.Drawing.Point(577, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Today Orders";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1689, 888);
=======
            this.label3.Location = new System.Drawing.Point(621, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Today\'s Orders";
            // 
            // DashboardForm
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1126, 641);
>>>>>>> b84597ba2fecdfbc5f6fc4f4bb9b8913e349d8f8
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvRecent);
            this.Controls.Add(this.lblTodayOrders);
            this.Controls.Add(this.lblLowStock);
            this.Controls.Add(this.lblTotalProducts);
            this.Controls.Add(this.lblTodaySales);
            this.Controls.Add(this.lblTodaySalesLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "DashboardForm";
<<<<<<< HEAD
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
=======
>>>>>>> b84597ba2fecdfbc5f6fc4f4bb9b8913e349d8f8
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}