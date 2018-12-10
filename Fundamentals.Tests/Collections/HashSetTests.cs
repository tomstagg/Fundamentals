using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Tests
{
    [TestClass]
    public class HashSetTests
    {
        [TestMethod]
        public void HashSetCanIntersect()
        {
            var set1 = new HashSet<int> { 1, 2, 3 };
            var set2 = new HashSet<int> { 2, 3, 4 };

            set1.IntersectWith(set2);

            Assert.IsTrue(set1.SetEquals(new [] { 2, 3 }));
        }

        [TestMethod]
        public void HashSetCanUnion()
        {
            var set1 = new HashSet<int> { 1, 2, 3 };
            var set2 = new HashSet<int> { 2, 3, 4 };

            set1.UnionWith(set2);

            Assert.IsTrue(set1.SetEquals(new[] { 1, 2, 3, 4 }));
            
        }

        [TestMethod]
        public void HashSetCanSymmetricExceptWith()
        {
            var set1 = new HashSet<int> { 1, 2, 3 };
            var set2 = new HashSet<int> { 2, 3, 4 };
            set1.SymmetricExceptWith(set2);
             
            Assert.IsTrue(set1.SetEquals(new[] { 1, 4 }));

        }
    }
}
