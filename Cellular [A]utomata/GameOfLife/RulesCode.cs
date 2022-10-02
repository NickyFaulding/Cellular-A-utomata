namespace Cellular__A_utomata.GameOfLife
{
    class Rules
    {
        private const int size = 30;
        private int[,] currentGrid;
        private int[,] newGrid;

        public int[,] Advance(int[,] _currentGrid, int[,] _newGrid)
        {
            currentGrid = _currentGrid;
            newGrid = _newGrid;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int neighbourCount = CheckNeighbours(i, j);
                    CheckRules(i, j, neighbourCount);
                }
            }

            return newGrid;
        }

        public void CheckRules(int i, int j, int neighbourCount)
        {
            //rule 1 reproduction
            //rule 2 & 3 underpop & overpop
            //rule 4 healthy

            if (currentGrid[i, j] == 0 && neighbourCount == 3)
            {
                newGrid[i, j] = 1;
            }
            else if (currentGrid[i, j] == 1 && (neighbourCount < 2 || neighbourCount > 3))
            {
                newGrid[i, j] = 0;
            }
            else if (currentGrid[i, j] == 1 && (neighbourCount == 2 || neighbourCount == 3))
            {
                newGrid[i, j] = currentGrid[i, j];
            }
        }

        public int CheckNeighbours(int i, int j)
        {
            int count = 0;

            for (int x = -1; x < 2; x++)
            {
                for (int y = -1; y < 2; y++)
                {
                    //wrap around edges  (0 - 1 + 30) % 30 = 29
                    if (currentGrid[(x + i + size) % size, (y + j + size) % size] == 1)
                    {
                        count++;
                    }
                }
            }

            if (currentGrid[i, j] == 1)
            {
                count--;
            }

            return count;
        }
    }
}
