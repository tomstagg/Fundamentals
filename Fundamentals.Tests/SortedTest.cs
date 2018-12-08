using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fundamentals.Tests
{
    [TestClass]
    public class SortedTest
    {
        [TestMethod]
        public void SortedListCanFind()
        {
            var list = new SortedList<int,string>
            {
                {1,"one" },
                {2,"two" },
                {3,"three" }
            };

            Assert.AreEqual(0, list.IndexOfKey(1));
            Assert.AreEqual(1, list.IndexOfValue("two"));
        }

        [TestMethod]
        public void SortedSetIsSorted()
        {
            var set = new SortedSet<int>();
            set.Add(3);
            set.Add(2);
            set.Add(1);
             
            var enumerator = set.GetEnumerator();
            enumerator.MoveNext();

            Assert.AreEqual(1, enumerator.Current);

        }
    }
}
