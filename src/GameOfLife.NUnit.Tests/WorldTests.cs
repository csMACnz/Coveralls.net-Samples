using NUnit.Framework;

namespace GameOfLife.NUnit.Tests
{
    [TestFixture]
    public class WorldTests
    {
        [Test]
        public void World_ConstructNew_WidthCorrect()
        {
            const int expectedWidth = 5;
            var data = new bool[expectedWidth, 12];

            var world = new World(data);

            Assert.AreEqual(expectedWidth, world.Width);
        }

        [Test]
        public void World_ConstructNew_HeightCorrect()
        {
            const int expectedHeight = 5;
            var data = new bool[12, expectedHeight];

            var world = new World(data);

            Assert.AreEqual(expectedHeight, world.Height);
        }
    }
}
