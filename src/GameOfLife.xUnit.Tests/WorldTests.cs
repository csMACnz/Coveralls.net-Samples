using Xunit;

namespace GameOfLife.xUnit.Tests
{
    public class WorldTests
    {
        [Fact]
        public void World_ConstructNew_WidthCorrect()
        {
            const int expectedWidth = 5;
            var data = new bool[expectedWidth, 12];

            var world = new World(data);

            Assert.Equal(expectedWidth, world.Width);
        }

        [Fact]
        public void World_ConstructNew_HeightCorrect()
        {
            const int expectedHeight = 5;
            var data = new bool[12, expectedHeight];

            var world = new World(data);

            Assert.Equal(expectedHeight, world.Height);
        }
    }
}
