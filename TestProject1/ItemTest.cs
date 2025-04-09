using GenSpil;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public sealed class ItemTest
    {
        [TestMethod]
        public void Item_ShouldTestProperties()
        {
            // Arrange & Act
            var item = new Item("Test Game", "1.0", 1, "Good", 4, 2022, 50, "Available");

            // Assert
            Assert.AreEqual("Test Game", item.Name);
            Assert.AreEqual("1.0", item.Version);
            Assert.AreEqual(1, item.ItemId);
            Assert.AreEqual("Good", item.Condition);
            Assert.AreEqual(4, item.Players);
            Assert.AreEqual(2022, item.YearReleased);
            Assert.AreEqual(50, item.Price);
            Assert.AreEqual("Available", item.ItemStatus);
        }
    }
}