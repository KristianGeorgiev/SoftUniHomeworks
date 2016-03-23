using _03.CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompanyHierarchy
{
    class Developer : RegularEmployee, IDeveloper
    {
        private IEnumerable<Project> projects;

        public Developer(int id, string firstName, string lastName, decimal salary, string department, IEnumerable<Project> projects)
            : base (id, firstName, lastName, salary, department)
        {
            this.Projects = projects;
        }

        public Developer(int id, string firstName, string lastName, decimal salary, string department)
            : this(id, firstName, lastName, salary, department, null)
        {

        }

        public IEnumerable<Project> Projects { get; set; }

        public override string ToString()
        {
            string developerInfo;

            developerInfo = string.Join("", "DEVELOPER INFO", "\n", "Id:", Id, "\n", "First name:", FirstName, "\n", "Last name:", LastName, "\n",
                "Salary:", Salary, "\n", "Department:", Department, "\n", "Developer`s projects:");

            foreach (Project project in Projects)
            {
                string currentProjectInfo;

                currentProjectInfo =string.Join("", "\"",  project.ProjectName, "\"");

                developerInfo += string.Join("", "\n", currentProjectInfo);
            }

            return developerInfo;
        }
    }
}
