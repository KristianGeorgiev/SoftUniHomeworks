using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals
{
    class Kitten : Cat
    {
        private const char kittenGender = 'f';

        public Kitten(string name, double age)
            : base (name, age, kittenGender)
        {

        }
    }
}
