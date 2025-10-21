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
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
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
=======
            this.lblTitle.Location = new System.Drawing.Point(18, 18);
>>>>>>> b84597ba2fecdfbc5f6fc4f4bb9b8913e349d8f8
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(221, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Employee Management";
            // 
            // btnCreate
            // 
<<<<<<< HEAD
            this.btnCreate.Location = new System.Drawing.Point(24, 146);
=======
            this.btnCreate.Location = new System.Drawing.Point(24, 95);
>>>>>>> b84597ba2fecdfbc5f6fc4f4bb9b8913e349d8f8
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create Employee";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.dgvEmployees.Location = new System.Drawing.Point(24, 175);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(1633, 626);
=======
            this.dgvEmployees.Location = new System.Drawing.Point(24, 124);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(1076, 406);
>>>>>>> b84597ba2fecdfbc5f6fc4f4bb9b8913e349d8f8
            this.dgvEmployees.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(1, 1);
<<<<<<< HEAD
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1689, 84);
=======
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 61);
>>>>>>> b84597ba2fecdfbc5f6fc4f4bb9b8913e349d8f8
            this.panel1.TabIndex = 3;
            // 
            // EmployeesForm
            // 
<<<<<<< HEAD
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1689, 888);
=======
            this.ClientSize = new System.Drawing.Size(1126, 641);
>>>>>>> b84597ba2fecdfbc5f6fc4f4bb9b8913e349d8f8
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.btnCreate);
            this.Name = "EmployeesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
    }
}