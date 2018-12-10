using System;
using Fundamentals.Generics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fundamentals.Tests.Generics
{
    [TestClass]
    public class CircularBufferTests
    {
        [TestMethod]
        public void CircleBufferCanWriteAValueAndReadTheValue()
        {
            var buffer = new CircularBuffer<int>();
            buffer.Write(39);

            Assert.AreEqual(39, buffer.Read());
        }

        [TestMethod]
        public void CircularBufferCanReadAndWriteTwoValues()
        {
            var buffer = new CircularBuffer<int>();
            buffer.Write(39);
            buffer.Write(40);

            Assert.AreEqual(39, buffer.Read());
            Assert.AreEqual(40, buffer.Read());
        }

        [TestMethod]
        public void BufferCanOverloadAndLosesValues()
        {
            var buffer = new CircularBuffer<int>(3);

            var values = new[] { 39, 40, 41, 42 };

            foreach (var value in values)
            {
                buffer.Write(value);
            }

            Assert.AreEqual(40, buffer.Read());
        }

        [TestMethod]
        public void BufferCanDetectIfEmptyWhenEmpty()
        {
            var buffer = new CircularBuffer<int>(3);
            Assert.IsTrue(buffer.IsEmpty);

            var values = new int[] { 1, 2, 3, 4 };

            foreach (var value in values)
            {
                buffer.Write(value);
            }

            for (int i = 1; i <= 3; i++)
            {
                buffer.Read();
            }

            Assert.IsTrue(buffer.IsEmpty);
        }

        [TestMethod]
        public void BufferCanDetectIfNotEmptyWhenHasValues()
        {
            var buffer = new CircularBuffer<int>(3);
            buffer.Write(1);
            Assert.IsFalse(buffer.IsEmpty);
            buffer.Write(2);
            Assert.IsFalse(buffer.IsEmpty);
            buffer.Write(3);
            Assert.IsFalse(buffer.IsEmpty);
        }


        [TestMethod]
        public void BufferCanDetectWhenFull()
        {
            var buffer = new CircularBuffer<int>(3);
            Assert.IsFalse(buffer.IsFull);
            buffer.Write(1);
            Assert.IsFalse(buffer.IsFull);
            buffer.Write(2);
            Assert.IsFalse(buffer.IsFull);
            buffer.Write(3);
            Assert.IsTrue(buffer.IsFull);
            buffer.Read();
            Assert.IsFalse(buffer.IsFull);
        }

        [TestMethod]
        public void BufferGenericTypesAreDifference()
        {
            var b1 = new CircularBuffer<int>();
            var b2 = new CircularBuffer<int>();
            var b3 = new CircularBuffer<string>();
            var b4 = new CircularBuffer<object>();

            Assert.IsTrue(b1.GetType() == b2.GetType());
            Assert.IsFalse(b1.GetType() == b3.GetType());
            Assert.IsFalse(b1.GetType() == b4.GetType()); // object is not of type int
        }
    }
}
