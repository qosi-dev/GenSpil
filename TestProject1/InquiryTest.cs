using GenSpil;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    [TestClass]
    public sealed class InquiryTest
    {
        [TestMethod]
        public void Inquiry_ShouldTestProperties()
        {
            // Arrange
            var customer = new Customer("John Doe", 1, "123 Street", 12345, "City", "1234567890", "john@example.com", DateTime.Now);

            // Act
            var inquiry = new Inquiry("Test Game", "1.0", "Good", customer, DateTime.Now);

            // Assert
            Assert.AreEqual("Test Game", inquiry.ItemName);
            Assert.AreEqual("1.0", inquiry.Version);
            Assert.AreEqual("Good", inquiry.Condition);
            Assert.AreEqual(customer, inquiry.RequestedBy);
        }
    }
}