using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesInventorySytemV3.Services.Interfaces;

namespace SalesInventorySytemV3.Forms.Employees
{
    public partial class EmployeesForm : Form
    {
        private readonly IEmployeeService _employeeService;
        public EmployeesForm(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
            InitializeComponent();
            LoadEmployees();
            timer1.Start();
        }

        private void LoadEmployees()
        {
            dgvEmployees.DataSource = null;
            dgvEmployees.DataSource = _employeeService.GetAll().Select(e => new { e.Username, e.FullName, Role = e.Role.ToString(), e.Status, Created = e.CreatedDate.ToShortDateString() }).ToList();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var f = new CreateEmployeeForm(_employeeService);
            if (f.ShowDialog() == DialogResult.OK) LoadEmployees();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.time.Text = datetime.ToString();
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            day.Text = System.DateTime.Now.DayOfWeek.ToString();
        }
    }
}