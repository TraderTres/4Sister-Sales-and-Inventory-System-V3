using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesInventorySytemV3.Services.Interfaces;

namespace SalesInventorySytemV3.Forms.Login
{
    public partial class LoginForm : Form
    {
        private readonly IAuthService _authService;
        private readonly IProductService _productService;
        private readonly ISalesService _salesService;
        private readonly IEmployeeService _employeeService;

        public LoginForm(IAuthService authService, IProductService productService, ISalesService salesService, IEmployeeService employeeService)
        {
            _authService = authService;
            _productService = productService;
            _salesService = salesService;
            _employeeService = employeeService;

            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
            var user = txtUsername.Text.Trim();
            var pass = txtPassword.Text;

            var emp = _authService.ValidateLogin(user, pass);
            if (emp != null)
            {
                var main = new Main.MainForm(emp, _productService, _salesService, _employeeService);
                this.Hide();
                main.FormClosed += (s, ev) => this.Close();
                main.Show();
            }
            else
            {
                lblError.Text = "Invalid username or password";
            }
        }
    }
}