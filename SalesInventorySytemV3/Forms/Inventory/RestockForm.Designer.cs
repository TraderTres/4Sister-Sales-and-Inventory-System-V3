namespace SalesInventorySytemV3.Forms.Inventory
{
    partial class RestockForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblPrompt = new System.Windows.Forms.Label();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Text = "Enter quantity to add:";
            this.lblPrompt.Location = new System.Drawing.Point(16, 12);
            // 
            // nudQty
            // 
            this.nudQty.Location = new System.Drawing.Point(16, 36);
            this.nudQty.Minimum = 1;
            this.nudQty.Maximum = 100000;
            this.nudQty.Value = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(34, 72);
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(130, 72);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // RestockForm
            // 
            this.ClientSize = new System.Drawing.Size(240, 110);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.nudQty);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Name = "RestockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Restock";
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}