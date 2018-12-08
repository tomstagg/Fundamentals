using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Tests
{
    [TestClass]
    public class DictionaryTests
    {
        [TestMethod]
        public void DictionaryCanFindValueForKey()
        {
            var map = new Dictionary<int, string>();
            map.Add(1, "one");
            map.Add(2, "two");

            Assert.AreEqual("two", map[2]);
        }

        [TestMethod]
        public void DictionaryCanSearchWithContains()
        {
            var map = new Dictionary<int, string>();
            map.Add(1, "one");
            map.Add(2, "two");

            Assert.IsTrue(map.ContainsKey(2));
        }
        [TestMethod]
        public void DictionaryCanRemoveByKey()
        {
            var map = new Dictionary<int, string>
            {
                { 1, "one" },
                { 2, "two" }
            };

            map.Remove(1);

            Assert.AreEqual(1, map.Count);
        }
    }
}
