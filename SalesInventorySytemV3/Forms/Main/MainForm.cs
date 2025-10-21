using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using SalesInventorySytemV3.Forms.Login;
=======
using SalesInventorySytemV3.Forms.Reports;
>>>>>>> b84597ba2fecdfbc5f6fc4f4bb9b8913e349d8f8
using SalesInventorySytemV3.Models;
using SalesInventorySytemV3.Services.Interfaces;

namespace SalesInventorySytemV3.Forms.Main
{
    public partial class MainForm : Form
    {
        private readonly Employee _currentUser;
        private readonly IProductService _productService;
        private readonly ISalesService _salesService;
        private readonly IEmployeeService _employeeService;
        private LoginForm _loginForm;

<<<<<<< HEAD
        public MainForm(Employee user, IProductService productService, ISalesService salesService, IEmployeeService employeeService, LoginForm loginForm)
        {
            _loginForm = loginForm;
=======
        private Form activeChild = null;

        public MainForm(Employee user, IProductService productService, ISalesService salesService, IEmployeeService employeeService)
        {
            InitializeComponent();
>>>>>>> b84597ba2fecdfbc5f6fc4f4bb9b8913e349d8f8

            _currentUser = user;
            _productService = productService;
            _salesService = salesService;
            _employeeService = employeeService;

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
                btnAnalytics.Visible = false; // ✅ hide Analytics for Cashier
            }
        }

        private void OpenChildForm(Form child)
        {
            if (activeChild != null)
            {
                activeChild.Close();
                panelContent.Controls.Clear();
            }

            activeChild = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panelContent.Controls.Add(child);
            panelContent.Tag = child;
            child.BringToFront();
            child.Show();
        }

<<<<<<< HEAD
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


    }
}
        
        
=======
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dashboard.DashboardForm(_productService, _salesService));
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sales.SalesForm(_productService, _salesService));
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Inventory.InventoryForm(_productService));
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Reports.ReportsForm(_productService, _salesService));
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Employees.EmployeesForm(_employeeService));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Print.PrintForm(_productService, _salesService));
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AnalyticsForm(_salesService, _productService));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
>>>>>>> b84597ba2fecdfbc5f6fc4f4bb9b8913e349d8f8
