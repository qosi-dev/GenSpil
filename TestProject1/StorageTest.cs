
using GenSpil;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public class StorageTests
    {
        [TestMethod]
        public void Storage_ShouldTestAddGameToStorage()
        {
            // Arrange
            Storage.Games.Clear();
            var initialCount = Storage.Games.Count;

            // Act
            Storage.Games.Add(new Item("Test Game", "1.0", 1, "Good", 4, 2022, 50, "På lager"));

            // Assert
            Assert.AreEqual(initialCount + 1, Storage.Games.Count);
        }

        [TestMethod]
        public void Storage_ShouldTestRemoveGameFromStorage()
        {
            // Arrange
            Storage.Games.Clear();
            Storage.Games.Add(new Item("Test Game", "1.0", 1, "Good", 4, 2022, 50, "På lager"));
            var initialCount = Storage.Games.Count;

            // Act
            Storage.Games.RemoveAt(0);

            // Assert
            Assert.AreEqual(initialCount - 1, Storage.Games.Count);
        }

        [TestMethod]
        public void Storage_ShouldTestStorage()
        {
            // Arrange
            var testItem = new Item("Test Game", "1.0", 1, "Good", 4, 2022, 50, "På lager");
            Storage.Games.Add(testItem);

            // Act
            var itemExists = Storage.Games.Contains(testItem);

            // Assert
            Assert.IsTrue(itemExists, "Spillet findes");
        }

    }
}