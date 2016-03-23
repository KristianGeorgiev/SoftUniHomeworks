using _03.CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompanyHierarchy
{
    class Sale : ISale
    {
        private string productName;
        private DateTime date;
        private decimal price;

        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public DateTime Date { get; set; }

        public string ProductName
        {
            get
            {
                return this.productName;
            }
            set
            {
                if (value == "" || value == null)
                {
                    throw new ArgumentNullException("Name is a mandatory.No empty strings accepted.");
                }

                this.productName = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price can not be negative,");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            string saleInformation;

            saleInformation = string.Join("", "SALE INFO", "\n", "Product name:", ProductName, "\n", "Date:", Date, "\n", "Price:", Price);

            return saleInformation;
        }
    }
}
