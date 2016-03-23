using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals
{
    public abstract class Animal : ISoundProducible
    {
        private string name;
        private double age;
        private char gender;

        protected Animal(string name, double age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == "" || value == null)
                {
                    throw new ArgumentNullException("Name is a mandatory and can not be an empty string");
                }

                this.name = value;
            }
        }

        public double Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("There is no animal on negative or 0 age.");
                }

                this.age = value;
            }
        }

        public char Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if (value != 'm' || value != 'f')
                {
                    throw new ArgumentException("The gender is m or f.");
                }

                this.gender = value;
            }
        }

        public abstract void ProduceSound();
    }
}