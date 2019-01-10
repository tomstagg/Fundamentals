using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Linq
{
    class LinqOverview
    {
        internal static void Run()
        {
            //Extensions
            DateTime date = new DateTime(2018, 2, 17);

            int daysTillEndOfMonth = DateUtilities.DaysToEndOfMonth(date);
            Console.WriteLine(daysTillEndOfMonth);

            daysTillEndOfMonth = date.DaysToEndOfMonthEx();
            Console.WriteLine(daysTillEndOfMonth);


            //Filtering
            IEnumerable<string> cities = new[] { "Ghent", "London", "Las Vegas", "Sydney" };

            IEnumerable<string> query = cities.StringsThatStartWith("L");
            foreach (var city in query)
            {
                Console.WriteLine(city);
            }


        }
    }

    public static class DateUtilities
    {
        public static int DaysToEndOfMonthEx(this DateTime date)
            => DateTime.DaysInMonth(date.Year, date.Month) - date.Day;

        public static int DaysToEndOfMonth(DateTime date)
            => DateTime.DaysInMonth(date.Year, date.Month) - date.Day;

    }

    public static class FilterExtensions
    {
        public static IEnumerable<string> StringsThatStartWith
           (this IEnumerable<string> input, string start)
        {
            foreach (var s in input)
            {
                if (s.StartsWith(start))
                    yield return s;
            }
        }

        public static IEnumerable<T> Filter<T>(this IEnumerable<T> input, FilterDelegate<T> predicate)
        {
            foreach (var item in input)
            {
                if (predicate(item))
                    yield return item;
            }
        }
    }

    public delegate bool FilterDelegate<T>(T item)
}
