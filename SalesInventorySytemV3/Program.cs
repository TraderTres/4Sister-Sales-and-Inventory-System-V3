using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesInventorySytemV3.Repositories.InMemory;
using SalesInventorySytemV3.Services.Interfaces;
using SalesInventorySytemV3.Services.Implementations;
using SalesInventorySytemV3.Repositories.Sql;


namespace SalesInventorySytemV3
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ========== 1. Repositories (SQL) ==========
            var productRepository = new ProductSqlRepository();
            var employeeRepository = new EmployeeSqlRepository();
            var saleRepository = new SaleSqlRepository();

            // ========== 2. Services ==========
            IAuthService authService = new AuthService(employeeRepository);
            IProductService productService = new ProductService(productRepository);
            ISalesService salesService = new SalesService(saleRepository, productRepository);
            IEmployeeService employeeService = new EmployeeService(employeeRepository);

            // ========== 3. Start LoginForm ==========
            Application.Run(new Forms.Login.LoginForm(
                authService,
                productService,
                salesService,
                employeeService
            ));
        }
    }
}