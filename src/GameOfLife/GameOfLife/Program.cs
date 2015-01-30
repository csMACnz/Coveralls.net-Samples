using System;
using System.Threading;

namespace GameOfLife
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //uncomment for different beginning states

            //var world = WorldBuilder.BuildBeaconWorld();
            //var world = WorldBuilder.BuildBlinkerWorld();
            //var world = WorldBuilder.BuildToadWorld();
            var world = WorldBuilder.BuildRandomWorld();

            while (true)
            {
                world = Game.GetNextWorldState(world);

                Console.Clear();

                Game.DrawWorld(world);

                Thread.Sleep(600);
            }
        }
    }
}
