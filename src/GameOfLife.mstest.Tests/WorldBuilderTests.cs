using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameOfLife.xUnit.Tests
{
    [TestClass]
    public class WorldBuilderTests
    {
        
        [TestMethod]
        public void WorldBuilder_BuildRandomWorld_WorldAsExpected()
        {
            const int expectedWidth = 10;
            const int expectedHeight = 10;

            var world = WorldBuilder.BuildRandomWorld();

            Assert.AreEqual(expectedWidth, world.Width);
            Assert.AreEqual(expectedHeight, world.Height);
        }

        [TestMethod]
        public void WorldBuilder_BuildBeaconWorld_WorldAsExpected()
        {
            const int expectedWidth = 10;
            const int expectedHeight = 10;

            var world = WorldBuilder.BuildBeaconWorld();

            Assert.AreEqual(expectedWidth, world.Width);
            Assert.AreEqual(expectedHeight, world.Height);
            Assert.IsFalse(world.IsAlive(0, 0));
            Assert.IsTrue(world.IsAlive(3, 3));
            Assert.IsTrue(world.IsAlive(3, 4));
            Assert.IsTrue(world.IsAlive(4, 3));
            Assert.IsTrue(world.IsAlive(5, 6));
            Assert.IsTrue(world.IsAlive(6, 5));
            Assert.IsTrue(world.IsAlive(6, 6));
            Assert.IsFalse(world.IsAlive(0, 9));
            Assert.IsFalse(world.IsAlive(9, 0));
            Assert.IsFalse(world.IsAlive(9, 9));
        }

        [TestMethod]
        public void WorldBuilder_BuildBlinkerWorld_WorldAsExpected()
        {
            const int expectedWidth = 10;
            const int expectedHeight = 10;

            var world = WorldBuilder.BuildBlinkerWorld();

            Assert.AreEqual(expectedWidth, world.Width);
            Assert.AreEqual(expectedHeight, world.Height);
            Assert.IsFalse(world.IsAlive(0, 0));
            Assert.IsFalse(world.IsAlive(0, 9));
            Assert.IsFalse(world.IsAlive(9, 0));
            Assert.IsFalse(world.IsAlive(9, 9));
            Assert.IsTrue(world.IsAlive(5, 4));
            Assert.IsTrue(world.IsAlive(5, 5));
            Assert.IsTrue(world.IsAlive(5, 6));
        }

        
        [TestMethod]
        public void WorldBuilder_BuildToadWorld_WorldAsExpected()
        {
            const int expectedWidth = 10;
            const int expectedHeight = 10;

            var world = WorldBuilder.BuildToadWorld();

            Assert.AreEqual(expectedWidth, world.Width);
            Assert.AreEqual(expectedHeight, world.Height);
            Assert.IsFalse(world.IsAlive(0, 0));
            Assert.IsFalse(world.IsAlive(0, 9));
            Assert.IsFalse(world.IsAlive(9, 0));
            Assert.IsFalse(world.IsAlive(9, 9));
            Assert.IsTrue(world.IsAlive(5, 4));
            Assert.IsTrue(world.IsAlive(5, 5));
            Assert.IsTrue(world.IsAlive(5, 6));
            Assert.IsTrue(world.IsAlive(6, 3));
            Assert.IsTrue(world.IsAlive(6, 4));
            Assert.IsTrue(world.IsAlive(6, 5));
        }
    }
}
