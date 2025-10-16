using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesInventorySytemV3.Repositories.InMemory;
using SalesInventorySytemV3.Services.Interfaces;
using SalesInventorySytemV3.Services.Implementations;


namespace SalesInventorySytemV3
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Repositories
            var productRepo = new InMemoryProductRepository();
            var employeeRepo = new InMemoryEmployeeRepository();
            var saleRepo = new InMemorySaleRepository();

            // Services
            IAuthService authService = new AuthService(employeeRepo);
            IProductService productService = new ProductService(productRepo);
            ISalesService salesService = new SalesService(saleRepo, productRepo);
            IEmployeeService employeeService = new EmployeeService(employeeRepo);

            // Start with LoginForm
            Application.Run(new Forms.Login.LoginForm(
                authService,
                productService,
                salesService,
                employeeService
            ));
        }
    }
}