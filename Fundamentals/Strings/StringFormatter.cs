﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Strings
{
    class StringFormatter
    {
        internal static void Run()
        {
            var context = "number";
            double number = 1.23456;
            Console.WriteLine($"{context,-6}:{number,6}");
            Console.WriteLine($"{context,-8}:{number,8}");
            Console.WriteLine($"{context,-10}:{number,10}");
            Console.WriteLine($"{context,-12}:{number,12}");
            Console.WriteLine($"{context,-12}:{number,12:N0}");
            Console.WriteLine($"{context,-12}:{number,12:N1}");

            Console.WriteLine($"{context,-12}:{number,12:N2}");

            Console.WriteLine(String.Format("{0} - {1}", "Tom", "Eva"));


            var message = "This is \r\n over two lines";
            Console.WriteLine(message);

            var verbatimMessage = @"This is \r\n over two lines";
            Console.WriteLine(verbatimMessage);

            var stringBuilder = new StringBuilder("this is");
            stringBuilder.Append(" a");
            stringBuilder.Append(" string built");
            stringBuilder.Replace("this", "replaced");
            Console.WriteLine(stringBuilder.ToString());




        }
    }
}
