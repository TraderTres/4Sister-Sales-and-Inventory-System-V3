namespace SalesInventorySytemV3.Forms.Reports
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbReportType;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtOutput;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbReportType = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 16);
            this.lblTitle.Text = "Reports & Analytics";
            // cbReportType
            this.cbReportType.Location = new System.Drawing.Point(20, 60); this.cbReportType.Width = 220;
            // btnGenerate
            this.btnGenerate.Text = "Generate"; this.btnGenerate.Location = new System.Drawing.Point(260, 58); this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // txtOutput
            this.txtOutput.Location = new System.Drawing.Point(20, 100); this.txtOutput.Width = 820; this.txtOutput.Height = 420; this.txtOutput.Multiline = true; this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical; this.txtOutput.ReadOnly = true;
            //
            this.ClientSize = new System.Drawing.Size(860, 540);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.cbReportType, this.btnGenerate, this.txtOutput });
            this.Name = "ReportsForm";
            this.Text = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        }
    }
}