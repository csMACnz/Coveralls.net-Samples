using System;
using System.Linq;

namespace GameOfLife
{
    public static class Game
    {
        public static void DrawWorld(World world)
        {
            foreach (int row in Enumerable.Range(0, world.Height))
            {
                foreach (int col in Enumerable.Range(0, world.Width))
                {
                    var isAlive = world.IsAlive(row, col);
                    Console.Write(isAlive ? "[#]" : "[ ]");
                }
                Console.WriteLine("");
            }
        }

        public static World GetNextWorldState(World world)
        {
            var newWorldData = new bool[world.Height, world.Width];
            foreach (int row in Enumerable.Range(0, world.Height))
            {
                foreach (int col in Enumerable.Range(0, world.Width))
                {
                    var neighbourLiveCount = 0;
                    var offsets = new[] {-1, 0, 1};
                    foreach (int rowOffset in offsets)
                    {
                        foreach (int colOffset in offsets)
                        {
                            if (rowOffset == 0 && colOffset == 0) continue;
                            var neighbourRow = row + rowOffset;
                            var neightbourColumn = col + colOffset;
                            if (neightbourColumn >= 0 &&
                                neightbourColumn < world.Width &&
                                neighbourRow >= 0 &&
                                neighbourRow < world.Height &&
                                world.IsAlive(neighbourRow, neightbourColumn)
                                )
                            {
                                neighbourLiveCount++;
                            }
                        }
                    }
                    bool newState;
                    var isCurrentlyAlive = world.IsAlive(row, col);
                    if (isCurrentlyAlive)
                    {
                        newState = neighbourLiveCount == 2 || neighbourLiveCount == 3;
                    }
                    else
                    {
                        newState = neighbourLiveCount == 3;
                    }
                    newWorldData[row, col] = newState;
                }
            }
            return new World(newWorldData);
        }
    }
}