using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesInventorySytemV3.Models;
using SalesInventorySytemV3.Services.Interfaces;

namespace SalesInventorySytemV3.Forms.Employees
{
    public partial class CreateEmployeeForm : Form
    {
        private readonly IEmployeeService _employeeService;
        public CreateEmployeeForm(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
            InitializeComponent();
            cbRole.Items.AddRange(new[] { Role.Administrator.ToString(), Role.Cashier.ToString() });
            cbRole.SelectedIndex = 1;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Fill required fields.");
                return;
            }

            if (txtPassword.Text != txtConfirm.Text) { MessageBox.Show("Passwords do not match."); return; }

            var emp = new Employee
            {
                Id = _employeeService.NextId(),
                Username = txtUsername.Text.Trim(),
                FullName = txtFullName.Text.Trim(),
                Password = txtPassword.Text,
                Role = (Role)Enum.Parse(typeof(Role), cbRole.SelectedItem.ToString()),
                Status = "active",
                CreatedDate = DateTime.Now
            };
            _employeeService.Add(emp);
            this.DialogResult = DialogResult.OK;
        }

        private void CreateEmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}