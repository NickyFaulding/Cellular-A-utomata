namespace Cellular__A_utomata.CellularAutomata
{
    class State
    {
        public State(int left, int current, int right)
        {
            Left = left;
            Current = current;
            Right = right;
        }

        int Left { get; set; }
        int Current { get; set; }
        int Right { get; set; }

        public int GetState()
        {
            if (Left == 1 && Current == 1 && Right == 1)
            {
                return 0;
            }

            else if (Left == 1 && Current == 1 && Right == 0)
            {
                return 1;
            }

            else if (Left == 1 && Current == 0 && Right == 1)
            {
                return 2;
            }

            else if (Left == 1 && Current == 0 && Right == 0)
            {
                return 3;
            }

            else if (Left == 0 && Current == 1 && Right == 1)
            {
                return 4;
            }

            else if (Left == 0 && Current == 1 && Right == 0)
            {
                return 5;
            }

            else if (Left == 0 && Current == 0 && Right == 1)
            {
                return 6;
            }

            // Left == 0 && Current == 0 && Right == 0
            else
            {
                return 7;
            }
        }
    }
}
