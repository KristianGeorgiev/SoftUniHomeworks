using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals
{
    class Tomcat : Cat
    {
        private const char tomcatGender = 'm';

        public Tomcat(string name, double age)
            : base (name, age, tomcatGender)
        {

        }
    }
}
