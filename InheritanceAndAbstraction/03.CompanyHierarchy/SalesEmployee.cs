using _03.CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompanyHierarchy
{
    class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private IEnumerable<Sale> sales;

        public SalesEmployee(int id, string firstName, string lastName, decimal salary, string department, IEnumerable<Sale> sales)
            : base(id, firstName, lastName, salary, department)
        {
            this.Sales = sales;
        }

        public IEnumerable<Sale> Sales { get; set; }

        public override string ToString()
        {
            string salesEmployeeInformation;

            salesEmployeeInformation = string.Join("", "REGULAR EMPLOYEE INFO", "\n", "Id:", Id, "\n", "First name:", FirstName, "\n", "Last name:", LastName, "\n",
                "Salary:", Salary, "\n", "Department:", Department, "\n", "Product names from sales:");

            foreach (Sale currentSale in Sales)
            {
                string currentSaleInfo;

                currentSaleInfo =string.Join("", "\"", currentSale.ProductName, "\"");

                salesEmployeeInformation += string.Join("", "\n", currentSaleInfo);
            }

            return salesEmployeeInformation;
        }
    }
}
