using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy
{
    class Employee : Person, IEmployee
    {
        private decimal salary;
        private string department;

        public Employee(int id, string firstName, string lastName, decimal salary, string department)
            : base (id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary can not be negative.");
                }

                this.salary = value;
            }
        }

        public string Department
        {
            get
            {
                return this.department;
            }
            set
            {
                if (value == "" || value != "Production" && value != "Accounting" && value != "Sales" && value != "Marketing")
                {
                    throw new ArgumentException("Department can not be an empty string or different than \"Sales\", \"Accounting\", \"Production\", or \"Marketing\"");
                }

                this.department = value;
            }
        }

        public override string ToString()
        {
            string employeeInfo;

            employeeInfo = string.Join("", "EMPLOYEE INFO", "\n", "Id:", Id, "\n", "First name:", FirstName, "\n", "Last name:", LastName, "\n",
                "sALARY:", Salary, "\n", "Department:", Department);

            return employeeInfo;
        }
    }
}
