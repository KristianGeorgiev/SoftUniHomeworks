using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentAndWorker
{
    class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                char[] lettersInFacNumber = value.ToCharArray();

                if (lettersInFacNumber.Length < 5 || lettersInFacNumber.Length > 10)
                {
                    throw new ArgumentException("The length of Faculty number should be between 5 and 10 characters");
                }

                this.facultyNumber = value;
            }
        }
    }
}
