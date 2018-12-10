using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Tests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void StackCanPeek()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Assert.AreEqual(3, stack.Peek());
        }

        [TestMethod]
        public void StackCanContain()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Assert.IsTrue(stack.Contains(2));

        }

        [TestMethod]
        public void StackCanConvertToArray()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);

            var array = stack.ToArray();

            Assert.AreEqual(1, array[1]);
        }
    }
    
}
