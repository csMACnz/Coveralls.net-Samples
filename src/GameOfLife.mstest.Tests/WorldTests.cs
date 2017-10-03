using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameOfLife.mstest.Tests
{
    [TestClass]
    public class WorldTests
    {
        [TestMethod]
        public void World_ConstructNew_WidthCorrect()
        {
            const int expectedWidth = 5;
            var data = new bool[expectedWidth, 12];

            var world = new World(data);

            Assert.AreEqual(expectedWidth, world.Width);
        }

        [TestMethod]
        public void World_ConstructNew_HeightCorrect()
        {
            const int expectedHeight = 5;
            var data = new bool[12, expectedHeight];

            var world = new World(data);

            Assert.AreEqual(expectedHeight, world.Height);
        }
    }
}
