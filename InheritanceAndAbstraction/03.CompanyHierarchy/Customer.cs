using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy
{
    class Customer : Person, ICustomer
    {
        private decimal netPurchaseAmount;

        public Customer(int id, string firstName, string lastName, decimal netPurchaseAmount)
            : base (id, firstName, lastName)
        {
            this.NetPurchraseAmount = netPurchaseAmount;
        }

        public decimal NetPurchraseAmount
        {
            get
            {
                return this.netPurchaseAmount;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Money can not be negative.");
                }

                this.netPurchaseAmount = value;
            }
        }

        public override string ToString()
        {
            string customerInformation;

            customerInformation = string.Join("","CUSTOMER INFO", "\n", "Id:", Id, "\n", "First name:", FirstName, "\n", "Last name:", LastName, "\n",
                "Net purchase amount:", NetPurchraseAmount);

            return customerInformation;
        }
    }
}
