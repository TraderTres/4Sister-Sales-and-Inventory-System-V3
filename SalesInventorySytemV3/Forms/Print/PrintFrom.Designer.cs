
namespace SalesInventorySytemV3.Forms.Print
{
    partial class PrintForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;

        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.CheckBox chkDateRange;
        private System.Windows.Forms.RadioButton rbInventory;
        private System.Windows.Forms.RadioButton rbSales;
        private System.Windows.Forms.RadioButton rbBoth;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.chkDateRange = new System.Windows.Forms.CheckBox();
            this.rbInventory = new System.Windows.Forms.RadioButton();
            this.rbSales = new System.Windows.Forms.RadioButton();
            this.rbBoth = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Print Reporting";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPrint.Location = new System.Drawing.Point(40, 200);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(150, 35);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print Preview";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpStartDate.Location = new System.Drawing.Point(40, 120);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(220, 26);
            this.dtpStartDate.TabIndex = 2;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpEndDate.Location = new System.Drawing.Point(280, 120);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(220, 26);
            this.dtpEndDate.TabIndex = 3;
            // 
            // chkDateRange
            // 
            this.chkDateRange.AutoSize = true;
            this.chkDateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkDateRange.Location = new System.Drawing.Point(40, 90);
            this.chkDateRange.Name = "chkDateRange";
            this.chkDateRange.Size = new System.Drawing.Size(230, 24);
            this.chkDateRange.TabIndex = 1;
            this.chkDateRange.Text = "Use Date Range (optional)";
            this.chkDateRange.UseVisualStyleBackColor = true;
            // 
            // rbInventory
            // 
            this.rbInventory.AutoSize = true;
            this.rbInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbInventory.Location = new System.Drawing.Point(40, 160);
            this.rbInventory.Name = "rbInventory";
            this.rbInventory.Size = new System.Drawing.Size(97, 24);
            this.rbInventory.TabIndex = 4;
            this.rbInventory.TabStop = true;
            this.rbInventory.Text = "Inventory";
            this.rbInventory.UseVisualStyleBackColor = true;
            // 
            // rbSales
            // 
            this.rbSales.AutoSize = true;
            this.rbSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbSales.Location = new System.Drawing.Point(140, 160);
            this.rbSales.Name = "rbSales";
            this.rbSales.Size = new System.Drawing.Size(72, 24);
            this.rbSales.TabIndex = 5;
            this.rbSales.TabStop = true;
            this.rbSales.Text = "Sales";
            this.rbSales.UseVisualStyleBackColor = true;
            // 
            // rbBoth
            // 
            this.rbBoth.AutoSize = true;
            this.rbBoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbBoth.Location = new System.Drawing.Point(220, 160);
            this.rbBoth.Name = "rbBoth";
            this.rbBoth.Size = new System.Drawing.Size(65, 24);
            this.rbBoth.TabIndex = 6;
            this.rbBoth.TabStop = true;
            this.rbBoth.Text = "Both";
            this.rbBoth.UseVisualStyleBackColor = true;
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.rbBoth);
            this.Controls.Add(this.rbSales);
            this.Controls.Add(this.rbInventory);
            this.Controls.Add(this.chkDateRange);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Name = "PrintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Reports";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}