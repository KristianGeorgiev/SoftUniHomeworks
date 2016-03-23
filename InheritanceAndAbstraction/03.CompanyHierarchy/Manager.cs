using _03.CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompanyHierarchy
{
    class Manager : Person, IManager
    {
        private IEnumerable<Employee> employees;

        public Manager(int id, string firstName, string lastName, IEnumerable<Employee> employees)
            : base (id, firstName, lastName)
        {
            this.Employees = employees;
        }

        public IEnumerable<Employee> Employees
        {
            get
            {
                return this.employees;
            }
            set
            {
                if (value.Count<Employee>() < 0)
                {
                    throw new ArgumentOutOfRangeException("Employees can not be less than one.");
                }

                this.employees = value;
            }
        }

        public override string ToString()
        {
            string managerInfo;

            managerInfo = string.Join("", "MANAGER INFO", "\n", "Id:", Id, "\n", "First name:", FirstName, "\n", "Last name:", LastName, "\n",
                "Manager`s employees:");

            foreach (Employee employee in Employees)
            {
                string employeeName;

                employeeName = string.Join(" ", employee.FirstName, employee.LastName);

                managerInfo += string.Join("", "\n", employeeName);
            }

            return managerInfo;
        }
    }
}
