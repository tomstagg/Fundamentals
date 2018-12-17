using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    class Product
    {
        public Product()
        {

        }
        public Product(string productDescription) : this()
        {
            this._productDescription = productDescription;
        }
        private string _productDescription;

        public string ProductDescription
        {
            get { return _productDescription; }
            set { _productDescription = value.Trim(); }
        }

    }

    class ProductRunner
    {
        internal static void Run()
        {
            // ways to create instance with 
            var p = new Product();
            p.ProductDescription = "bike ";

            var p2 = new Product
            {
                ProductDescription = "scooter"
            };

            var p3 = new Product("rocket");

            Console.WriteLine(p.ProductDescription);
            Console.WriteLine(p2.ProductDescription);
            Console.WriteLine(p3.ProductDescription);


        }
    }
}
