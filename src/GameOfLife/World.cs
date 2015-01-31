namespace GameOfLife
{
    public class World
    {
        private readonly bool[,] _data;

        public World(bool[,] data)
        {
            Width = data.GetUpperBound(0) + 1;
            Height = data.GetUpperBound(1) + 1;
            _data = data;
        }

        public int Width { get; private set; }
        public int Height { get; private set; }

        public bool IsAlive(int x, int y)
        {
            return _data[x, y];
        }
    }
}