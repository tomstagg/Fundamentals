using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fundamentals.Test
{
    [TestClass]
    public class ListTests
    {
        [TestMethod]
        public void ListCanInsert()
        {
            List<int> integers = new List<int>() { 1, 2, 3 };
            integers.Insert(1, 4);

            Assert.AreEqual(4, integers[1]);
            Assert.AreEqual(3, integers[3]);

        }

        [TestMethod]
        public void ListCanDelete()
        {
            List<int> integers = new List<int> { 1, 2, 3 };
            integers.Remove(2);
            Assert.IsTrue(integers.SequenceEqual(new[] { 1, 3 }));
        }

        [TestMethod]
        public void ListCanFindItems()
        {
            List<int> integers = new List<int> { 1, 2, 3 };

            Assert.AreEqual(2, integers.IndexOf(3));
        }
    }
}
