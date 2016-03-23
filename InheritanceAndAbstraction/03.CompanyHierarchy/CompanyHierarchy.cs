using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompanyHierarchy
{
    class CompanyHierarchy
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2005, 03, 15);
            DateTime date1 = new DateTime(2006, 05, 29);
            DateTime date2 = new DateTime(2015, 12, 03);

            Sale saleOne = new Sale("WhatsApp", date, 25639.48M);
            Sale saleTwo = new Sale("Viber", date1, 5000859.98M);
            Sale saleThree = new Sale("LinkedIn", date2, 85265986.07M);

            List<Sale> sales = new List<Sale>();

            sales.Add(saleOne);
            sales.Add(saleTwo);
            sales.Add(saleThree);

            Project projectOne = new Project("Clinic", date, "closed");
            Project projectTwo = new Project("School", date1, "closed");
            Project projectThree = new Project("Disco", date2, "open");

            List<Project> projects = new List<Project>();

            projects.Add(projectOne);
            projects.Add(projectTwo);
            projects.Add(projectThree);

            SalesEmployee salesEmployee = new SalesEmployee(2, "Marin", "Georgiev", 1750.45M, "Sales", sales);
            Developer developer = new Developer(3, "Veselin", "Angelov", 1600.00M, "Production", projects);

            List<Employee> allEmployees = new List<Employee>();

            allEmployees.Add(salesEmployee);
            allEmployees.Add(developer);

            Manager manager = new Manager(1, "Simeon", "Simov", allEmployees);

            List<Person> persons = new List<Person>();

            persons.Add(salesEmployee);
            persons.Add(developer);
            persons.Add(manager);

            foreach (Person currentPerson in persons)
            {
                Console.WriteLine(currentPerson);
            }
        }
    }
}
