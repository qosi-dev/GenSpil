using GenSpil;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    [TestClass]
    public sealed class CustomerTest
    {
        [TestMethod]
        public void CreateCustomer_ShouldTestAddCustomerToList()
        {
            // Arrange
            Customer.Customers.Clear();
            var CustomerCounter = Customer.Customers.Count;

            // Act
            Customer.Customers.Add(new Customer("John Doe", 1, "123 Street", 12345, "City", "1234567890", "john@example.com", DateTime.Now));

            // Assert
            Assert.AreEqual(CustomerCounter + 1, Customer.Customers.Count);
        }
    }
}