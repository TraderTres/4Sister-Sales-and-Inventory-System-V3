using SalesInventorySytemV3.Forms.Login;
using SalesInventorySytemV3.Models;
using SalesInventorySytemV3.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesInventorySytemV3.Forms.Main
{
    public partial class MainForm : Form
    {
        private readonly Employee _currentUser;
        private readonly IProductService _productService;
        private readonly ISalesService _salesService;
        private readonly IEmployeeService _employeeService;
        private LoginForm _loginForm;

        public MainForm(Employee user, IProductService productService, ISalesService salesService, IEmployeeService employeeService, LoginForm loginForm)
        {
            _currentUser = user;
            _productService = productService;
            _salesService = salesService;
            _employeeService = employeeService;
            _loginForm = loginForm;

            InitializeComponent();
            lblUserInfo.Text = $"{_currentUser.Role}: {_currentUser.Username}";
            ApplyRolePermissions();
            OpenChildForm(new Dashboard.DashboardForm(_productService, _salesService));
        }
        private void ApplyRolePermissions()
        {
            if (_currentUser.Role == Role.Cashier)
            {
                btnInventory.Visible = false;
                btnReports.Visible = false;
                btnEmployees.Visible = false;
            }
        }

        private Form activeChild = null;
        private void OpenChildForm(Form child)
        {
            if (activeChild != null)
            {
                activeChild.Close();
                panelContent.Controls.Clear();
            }
            activeChild = child;
            child.TopLevel = false;
            child.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panelContent.Controls.Add(child);
            child.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e) => OpenChildForm(new Dashboard.DashboardForm(_productService, _salesService));
        private void btnSales_Click(object sender, EventArgs e) => OpenChildForm(new Sales.SalesForm(_productService, _salesService));
        private void btnInventory_Click(object sender, EventArgs e) => OpenChildForm(new Inventory.InventoryForm(_productService));
        private void btnReports_Click(object sender, EventArgs e) => OpenChildForm(new Reports.ReportsForm(_productService, _salesService));
        private void btnEmployees_Click(object sender, EventArgs e) => OpenChildForm(new Employees.EmployeesForm(_employeeService));
        private void btnLogout_Click(object sender, EventArgs e) 
        {
            this.Close();
            _loginForm.ResetFields();
            _loginForm.Show();
        }
        private void btnPrint_Click(object sender, EventArgs e) => OpenChildForm(new Print.PrintForm(_productService, _salesService));

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblUserInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnAnalytics_Click(object sender, EventArgs e) => OpenChildForm(new Analytics.AnalyticsForm(_productService, _salesService));


    }
}
        
        
