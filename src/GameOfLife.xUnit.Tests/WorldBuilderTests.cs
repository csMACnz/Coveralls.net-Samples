using Xunit;

namespace GameOfLife.xUnit.Tests
{
    public class WorldBuilderTests
    {
        
        [Fact]
        public void WorldBuilder_BuildRandomWorld_WorldAsExpected()
        {
            const int expectedWidth = 10;
            const int expectedHeight = 10;

            var world = WorldBuilder.BuildRandomWorld();

            Assert.Equal(expectedWidth, world.Width);
            Assert.Equal(expectedHeight, world.Height);
        }

        [Fact]
        public void WorldBuilder_BuildBeaconWorld_WorldAsExpected()
        {
            const int expectedWidth = 10;
            const int expectedHeight = 10;

            var world = WorldBuilder.BuildBeaconWorld();

            Assert.Equal(expectedWidth, world.Width);
            Assert.Equal(expectedHeight, world.Height);
            Assert.False(world.IsAlive(0, 0));
            Assert.True(world.IsAlive(3, 3));
            Assert.True(world.IsAlive(3, 4));
            Assert.True(world.IsAlive(4, 3));
            Assert.True(world.IsAlive(5, 6));
            Assert.True(world.IsAlive(6, 5));
            Assert.True(world.IsAlive(6, 6));
            Assert.False(world.IsAlive(0, 9));
            Assert.False(world.IsAlive(9, 0));
            Assert.False(world.IsAlive(9, 9));
        }

        [Fact]
        public void WorldBuilder_BuildBlinkerWorld_WorldAsExpected()
        {
            const int expectedWidth = 10;
            const int expectedHeight = 10;

            var world = WorldBuilder.BuildBlinkerWorld();

            Assert.Equal(expectedWidth, world.Width);
            Assert.Equal(expectedHeight, world.Height);
            Assert.False(world.IsAlive(0, 0));
            Assert.False(world.IsAlive(0, 9));
            Assert.False(world.IsAlive(9, 0));
            Assert.False(world.IsAlive(9, 9));
            Assert.True(world.IsAlive(5, 4));
            Assert.True(world.IsAlive(5, 5));
            Assert.True(world.IsAlive(5, 6));
        }

        
        [Fact]
        public void WorldBuilder_BuildToadWorld_WorldAsExpected()
        {
            const int expectedWidth = 10;
            const int expectedHeight = 10;

            var world = WorldBuilder.BuildToadWorld();

            Assert.Equal(expectedWidth, world.Width);
            Assert.Equal(expectedHeight, world.Height);
            Assert.False(world.IsAlive(0, 0));
            Assert.False(world.IsAlive(0, 9));
            Assert.False(world.IsAlive(9, 0));
            Assert.False(world.IsAlive(9, 9));
            Assert.True(world.IsAlive(5, 4));
            Assert.True(world.IsAlive(5, 5));
            Assert.True(world.IsAlive(5, 6));
            Assert.True(world.IsAlive(6, 3));
            Assert.True(world.IsAlive(6, 4));
            Assert.True(world.IsAlive(6, 5));
        }
    }
}
