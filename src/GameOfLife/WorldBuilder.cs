using System;
using System.Linq;

namespace GameOfLife
{
    public static class WorldBuilder
    {
        private const int DefaultWidth = 10;
        private const int DefaultHeight = 10;

        public static World BuildBlinkerWorld()
        {
            var world = new bool[DefaultHeight, DefaultWidth];
            
            world[5, 4] = true;
            world[5, 5] = true;
            world[5, 6] = true;

            return new World(world);
        }

        public static World BuildToadWorld()
        {
            var world = new bool[DefaultHeight, DefaultWidth];

            world[5, 4] = true;
            world[5, 5] = true;
            world[5, 6] = true;
            world[6, 3] = true;
            world[6, 4] = true;
            world[6, 5] = true;

            return new World(world);
        }

        public static World BuildBeaconWorld()
        {
            var world = new bool[DefaultHeight, DefaultWidth];

            world[3, 3] = true;
            world[3, 4] = true;
            world[4, 3] = true;
            world[5, 6] = true;
            world[6, 5] = true;
            world[6, 6] = true;

            return new World(world);
        }

        public static World BuildRandomWorld()
        {
            var world = new bool[DefaultHeight, DefaultWidth];
            
            var random = new Random((int)DateTime.Now.Ticks % Int32.MaxValue);
            foreach (int row in Enumerable.Range(0, DefaultHeight))
            {
                foreach (int col in Enumerable.Range(0, DefaultWidth))
                {
                    world[row, col] = random.Next(2) == 1;
                }
            }
            return new World(world);
        }
    }
}