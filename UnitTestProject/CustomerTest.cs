using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyProgram;

namespace UnitTestProject
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void CustomerWelcome()
        {
            // Arrange
            string name = "Joseph";
            string expected = "Welcome " + name;

            // Act
            string result = Customer.GetCustomerWelcome(name);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(System.IndexOutOfRangeException))]
        public void CustomerException()
        {
            // Arrange
            Customer[] customers = new Customer[2];

            // Act
            customers[2] = new Customer();            
        }
    }
}
