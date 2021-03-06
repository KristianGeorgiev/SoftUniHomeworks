﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentAndWorker
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
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
                    throw new ArgumentNullException("First name is a mandatory and can not be an empty string");
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
                    throw new ArgumentNullException("Last name is a mandatory and can not be an empty string");
                }

                this.lastName = value;
            }
        }
    }
}
