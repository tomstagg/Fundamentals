using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Classes.MethodParameters
{
    class ProductCalculated
    {
        public ProductCalculated(double price, int daysToDeliver)
        {
            Price = price;
            DaysToDeliver = daysToDeliver;
        }

        public double Price { get; set; }
        public int DaysToDeliver { get; set; }

    }
    class Product
    {
        public string Name { get; set; }
        public enum SendOverseas { Yes, No };
        public enum AddVat { Yes, No };

        public double CalculatePrice(int quantity, bool IsOverseas, bool IsVat)
        {
            return 10 * quantity * (IsOverseas ? 1.04 : 1) * (IsVat ? 1.175 : 1);
        }

        //expression bodied method using lambda
        public double CalculatePriceEx(int quantity, bool IsOverseas, bool IsVat)
            => 10 * quantity * (IsOverseas ? 1.04 : 1) * (IsVat ? 1.175 : 1);

        // method chaining
        public double CalculatePriceBasic(int quantity)
            => CalculatePriceEx(quantity, IsOverseas: true, IsVat: true);

        // using Enums instead of bools
        public double CalculatePrice(int quantity, SendOverseas sendOverseas, AddVat addVat)
            => 10 * quantity * (sendOverseas == SendOverseas.Yes ? 1.04 : 1) * (addVat == AddVat.Yes ? 1.175 : 1);

        // using optional Enums
        public double CalculatePriceOptional(int quantity, SendOverseas sendOverseas = SendOverseas.Yes, AddVat addVat = AddVat.Yes)
            => 10 * quantity * (sendOverseas == SendOverseas.Yes ? 1.04 : 1) * (addVat == AddVat.Yes ? 1.175 : 1);

        public ProductCalculated CalculatePriceOptionalReturn(int quantity, SendOverseas sendOverseas = SendOverseas.Yes, AddVat addVat = AddVat.Yes)
        {
            var price = 10 * quantity * (sendOverseas == SendOverseas.Yes ? 1.04 : 1) * (addVat == AddVat.Yes ? 1.175 : 1);
            return new ProductCalculated(price: price, daysToDeliver: 5);
        }
    }

    static class MethodParameterRunner
    {
        internal static void Run()
        {
            var product = new Product();
            var result = product.CalculatePrice(10, true, false);
            Console.WriteLine($"CalculatePrice: {result}");

            result = product.CalculatePrice(quantity: 10, IsOverseas: true, IsVat: false);
            Console.WriteLine($"CalculatePrice with defaul: {result}");
            result = product.CalculatePriceBasic(quantity: 10);
            Console.WriteLine($"CalculatePriceBasic: {result}");

            result = product.CalculatePrice(10, Product.SendOverseas.Yes, Product.AddVat.No);
            Console.WriteLine($"CalculatePriceEnum: {result}");

            result = product.CalculatePriceOptional(quantity: 10);
            Console.WriteLine($"CalculatePriceEnumOptional: {result}");

            var productCalculated = product.CalculatePriceOptionalReturn(quantity: 10, sendOverseas: Product.SendOverseas.No, addVat: Product.AddVat.No);
            Console.WriteLine($"CalculatePriceOptionalReturn: {productCalculated.Price}, {productCalculated.DaysToDeliver}");
        }
    }
}
