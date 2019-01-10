using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fundamentals.Tests.Strings
{
    [TestClass]
    public class StringFormatter
    {
        [TestMethod]
        public void StringOperations()
        {
            string message = "My Name is Tom";

            if (!string.IsNullOrWhiteSpace(message))
            { 
            Assert.AreEqual("MY NAME IS TOM", message.ToUpper());
            //using null condition operator
            Assert.AreEqual("my name is tom", message?.ToLower());
            Assert.AreEqual("My Name is Seb", message.Replace("Tom", "Seb"));
            Assert.AreEqual(14, message.Length);
            Assert.AreEqual(8, message.IndexOf("i"));
            Assert.IsTrue(message.StartsWith("My Name"));
            }
            else
            {
                Assert.IsTrue(false);
            }


        }
    }
}
