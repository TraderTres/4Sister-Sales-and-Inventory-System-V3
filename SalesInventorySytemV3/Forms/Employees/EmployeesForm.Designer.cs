namespace SalesInventorySytemV3.Forms.Employees
{
    partial class EmployeesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dgvEmployees;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 16);
            this.lblTitle.Text = "Employee Management";
            // 
            this.btnCreate.Location = new System.Drawing.Point(20, 60);
            this.btnCreate.Text = "Create Employee";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            this.dgvEmployees.Location = new System.Drawing.Point(20, 100);
            this.dgvEmployees.Size = new System.Drawing.Size(820, 420);
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            this.ClientSize = new System.Drawing.Size(860, 540);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblTitle);
            this.Name = "EmployeesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}