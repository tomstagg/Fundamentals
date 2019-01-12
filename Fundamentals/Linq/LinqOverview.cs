using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

            //Filtering using extension
            IEnumerable<string> extensionQuery = cities.StringsThatStartWith("L");
            WriteContents(extensionQuery);

            //Filtering using a delegate
            IEnumerable<string> filterQuery = cities.Filter(StringsThatStartWithL);
            WriteContents(filterQuery);

            //Filtering using anonomous delegate
            IEnumerable<string> anonFilterQuery = cities.Filter(delegate (string item)
            {
                return item.StartsWith("L");
            });
            WriteContents(filterQuery);

            //Filtering with lamda expression (C# 3.0 and above)
            IEnumerable<string> lambaFilterQuery = cities.Filter(item => item.StartsWith("L"));
            WriteContents(filterQuery);

            //Functions
            WorkWithFuncAndAction();
            WorkWithFuncAndActionExpression();

            //Filtering with func
            IEnumerable<string> lambaFilterFuncQuery = cities.FilterFunc(item => item.StartsWith("L"));
            WriteContents(lambaFilterFuncQuery);

            // Linq with Where
            IEnumerable<string> linqQuery = cities.Where(city => city.StartsWith("L"))
                                                  .OrderByDescending(city => city.Length);
            WriteContents(linqQuery);


            // query syntax
            IEnumerable<string> comprehensionQuery =
                from city in cities
                where city.StartsWith("L") && city.Length < 15
                orderby city
                select city;

            WriteContents(comprehensionQuery);

        }

        private static void WorkWithFuncAndAction()
        {
            Func<int, int> square = x => x * x;
            Func<int, int, int> add = (x, y) => x + y;
            Action<int> print = x => Console.WriteLine(x);
            print(square(add(3, 1)));
        }

        private static void WorkWithFuncAndActionExpression()
        {
            Expression<Func<int, int>> square = x => x * x; // debug this line to show   
            Func<int, int, int> add = (x, y) => x + y;
            Action<int> print = x => Console.WriteLine(x);
        }

        static bool StringsThatStartWithL(string s)
        {
            return s.StartsWith("L");
        }
        
        static void WriteContents(IEnumerable<string> contents)
        {
            Console.WriteLine();
            foreach (var item in contents)
            {
                Console.WriteLine(item);
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

        public static IEnumerable<T> FilterFunc<T>(this IEnumerable<T> input, Func<T, bool> predicate)
        {
            foreach (var item in input)
            {
                if (predicate(item))
                    yield return item;
            }
        }
    }

    public delegate bool FilterDelegate<T>(T item);
}
