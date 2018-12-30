using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fundamentals.Tests.Methods
{

    public class Person
    {
        public string Name { get; set; }
    }

    [TestClass]
    public class ParameterPassingRefOutTests
    {
        [TestMethod]
        public void ValueTypePassByValue()
        {
            int x = 2;

            IncrementValue(x);

            // copy of the value is passed to the method, no change to first version
            Assert.AreEqual(2, x);
        }

        private void IncrementValue(int x)
        {
            x += 1;
        }

        [TestMethod]
        public void ReferenceTypePassByValue()
        {
            Person person = new Person();
            person.Name = "Em";
            Person person2 = person;

            SetNameToTom(person2);
            // object reference is passed by value, pointing at same object so can update it
            Assert.AreEqual("Tom", person.Name);
        }

        private void SetNameToTom(Person p)
        {
            p.Name = "Tom";
        }

        [TestMethod]
        public void ValueTypePassByReference()
        {
            int x = 2;

            IncrementValueRef(ref x);

            // a 
            Assert.AreEqual(3, x);

        }

        private void IncrementValueRef(ref int x)
        {
            x += 1;
        }

        [TestMethod]
        public void ReferenceTypePassByReference()
        {
            Person person = new Person
            {
                Name = "Em"
            };
            SetNameToTomRef(ref person);

            Assert.AreEqual("Tom", person.Name);
        }

        private void SetNameToTomRef(ref Person gradeBook)
        {
            gradeBook = new Person();
            gradeBook.Name = "Tom";
        }

        [TestMethod]
        public void OutParameter()
        {
            int x;

            SetToTwo(out x);

            Assert.AreEqual(2, x);

        }

        private void SetToTwo(out int x)
        {
            x = 2;

        }
    }
}
