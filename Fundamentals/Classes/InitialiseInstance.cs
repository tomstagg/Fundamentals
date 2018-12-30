using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Classes.InitaliseInstance
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

        public double Price { get; set; } = 10;

        // getter without setter and set value
        public string FixedProperty { get; } = "I'm fixed";
    }

    class InitaliseInstanceRunner
    {
        internal static void Run()
        {
            // ways to initialise objects:
            // setting properties
            var p = new Product();
            p.ProductDescription = "bike ";

            // object initialiser
            var p2 = new Product
            {
                ProductDescription = "scooter"
            };

            // parameterised constructor
            var p3 = new Product("rocket");

            Console.WriteLine(p.ProductDescription);
            Console.WriteLine(p2.ProductDescription);
            Console.WriteLine(p3.ProductDescription);
        }
    }
}
