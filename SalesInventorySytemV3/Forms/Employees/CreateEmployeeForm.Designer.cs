namespace SalesInventorySytemV3.Forms.Employees
{
    partial class CreateEmployeeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblFull;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Button btnCreate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblUsername = new System.Windows.Forms.Label(); this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblFull = new System.Windows.Forms.Label(); this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label(); this.cbRole = new System.Windows.Forms.ComboBox();
            this.lblPassword = new System.Windows.Forms.Label(); this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label(); this.txtConfirm = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            // layout compact
            this.lblUsername.Text = "Username"; this.lblUsername.Location = new System.Drawing.Point(20, 16);
            this.txtUsername.Location = new System.Drawing.Point(20, 34); this.txtUsername.Width = 360;
            this.lblFull.Text = "Full Name"; this.lblFull.Location = new System.Drawing.Point(20, 68);
            this.txtFullName.Location = new System.Drawing.Point(20, 86); this.txtFullName.Width = 360;
            this.lblRole.Text = "Role"; this.lblRole.Location = new System.Drawing.Point(20, 120);
            this.cbRole.Location = new System.Drawing.Point(20, 138); this.cbRole.Width = 360;
            this.lblPassword.Text = "Password"; this.lblPassword.Location = new System.Drawing.Point(20, 172);
            this.txtPassword.Location = new System.Drawing.Point(20, 190); this.txtPassword.Width = 360; this.txtPassword.UseSystemPasswordChar = true;
            this.lblConfirm.Text = "Confirm Password"; this.lblConfirm.Location = new System.Drawing.Point(20, 224);
            this.txtConfirm.Location = new System.Drawing.Point(20, 242); this.txtConfirm.Width = 360; this.txtConfirm.UseSystemPasswordChar = true;
            this.btnCreate.Text = "Create"; this.btnCreate.Location = new System.Drawing.Point(220, 280); this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            //
            this.ClientSize = new System.Drawing.Size(420, 330);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblUsername, this.txtUsername, this.lblFull, this.txtFullName, this.lblRole, this.cbRole, this.lblPassword, this.txtPassword, this.lblConfirm, this.txtConfirm, this.btnCreate });
            this.Name = "CreateEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Employee";
        }
    }
}