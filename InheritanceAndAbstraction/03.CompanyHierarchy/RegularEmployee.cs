using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompanyHierarchy
{
    abstract class RegularEmployee : Employee
    {
        public RegularEmployee(int id, string firstName, string lastName, decimal salary, string department)
            : base (id, firstName, lastName, salary, department)
        {

        }

        public override string ToString()
        {
            string regularEmployeeInformation;

            regularEmployeeInformation = string.Join("", "REGULAR EMPLOYEE INFO", "\n", "Id:", Id, "\n", "First name:", FirstName, "\n", "Last name:", LastName, "\n",
                "Salary:", Salary, "\n", "Department:", Department);

            return regularEmployeeInformation;
        }
    }
}
