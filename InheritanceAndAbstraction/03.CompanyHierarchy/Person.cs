using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompanyHierarchy
{
    public abstract class Person : IPerson
    {
        private int id;
        private string firstName;
        private string lastName;

        protected Person(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Id
        {
            get
            {
                return id += 1;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("ID can not be negative.");
                }

                this.id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value == "" || value == null)
                {
                    throw new ArgumentNullException("First name is a mandatory. No empty strings accepted.");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value == "" || value == null)
                {
                    throw new ArgumentNullException("Last name is a mandatory. No empty strings accepted.");
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            string personInfo;

            personInfo = string.Join("", "PERSON INFO", "\n", "Id:", Id, "\n", "First name:", FirstName, "\n", "Last name:", LastName);

            return personInfo;
        }
    }
}
