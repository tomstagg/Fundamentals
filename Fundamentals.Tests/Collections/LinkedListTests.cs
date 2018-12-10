using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Tests
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void LinkedListCanAddAfter()
        {
            var list = new LinkedList<string>();

            list.AddFirst("hello");
            list.AddLast("world");
            list.AddAfter(list.First, "tom");

            Assert.AreEqual("tom", list.First.Next.Value);
        }

        [TestMethod]
        public void LinkedListCanRemoveLast()
        {
            var list = new LinkedList<string>();

            list.AddFirst("eva");
            list.AddLast("seb");
            list.RemoveLast();

            Assert.AreEqual(list.Last, list.First);
        }

        [TestMethod]
        public void LinkedListCanFindItems()
        {
            var list = new LinkedList<string>();
            list.AddFirst("em");
            list.AddLast("tom");
            Assert.IsTrue(list.Contains("tom"));
        }
    }
}
