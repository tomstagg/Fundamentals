using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fundamentals.Test
{
    [TestClass]
    public class QueueTests
    {
        [TestMethod]
        public void QueueCanPeekAtNextItem()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Assert.AreEqual(1, queue.Peek());
        }

        [TestMethod]
        public void QueueCanSearch()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Assert.IsTrue(queue.Contains(2));
            Assert.IsFalse(queue.Contains(4));
        }
    }
}
