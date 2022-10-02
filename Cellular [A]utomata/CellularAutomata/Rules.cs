using System.Collections.Generic;

namespace Cellular__A_utomata.CellularAutomata
{
    partial class Rules
    {
        private const int size = 30;

        private int[] currentCells;
        private int[] newCells;

        private int currentRule = 1;

        Dictionary<int, int[]> AllRules = new Dictionary<int, int[]>();

        private int[] rule01 = { 0, 0, 0, 0, 0, 0, 0, 1 };
        private int[] rule02 = { 0, 0, 0, 0, 0, 0, 1, 0 };
        private int[] rule03 = { 0, 0, 0, 0, 0, 0, 1, 1 };
        private int[] rule04 = { 0, 0, 0, 0, 0, 1, 0, 0 };
        private int[] rule05 = { 0, 0, 0, 0, 0, 1, 0, 1 };
        private int[] rule06 = { 0, 0, 0, 0, 0, 1, 1, 0 };
        private int[] rule07 = { 0, 0, 0, 0, 0, 1, 1, 1 };
        private int[] rule08 = { 0, 0, 0, 0, 1, 0, 0, 0 };
        private int[] rule09 = { 0, 0, 0, 0, 1, 0, 0, 1 };
        private int[] rule10 = { 0, 0, 0, 0, 1, 0, 1, 0 };

        private int[] rule18 = { 0, 0, 0, 1, 0, 0, 1, 0 };
        private int[] rule28 = { 0, 0, 0, 1, 1, 1, 0, 0 };
        private int[] rule30 = { 0, 0, 0, 1, 1, 1, 1, 0 };
        private int[] rule50 = { 0, 0, 1, 1, 0, 0, 1, 0 };
        private int[] rule69 = { 0, 1, 0, 0, 0, 1, 0, 1 };

        private int[] rule165 = { 1, 0, 1, 0, 0, 1, 0, 1 }; //inverse of rule 18

        private int[] selectedRule = { 0, 0, 0, 0, 0, 0, 0, 0 };

        public Rules()
        {
            AllRules.Add(1, rule01);
            AllRules.Add(2, rule02);
            AllRules.Add(3, rule03);
            AllRules.Add(4, rule04);
            AllRules.Add(5, rule05);
            AllRules.Add(6, rule06);
            AllRules.Add(7, rule07);
            AllRules.Add(8, rule08);
            AllRules.Add(9, rule09);
            AllRules.Add(10, rule10);

            AllRules.Add(18, rule18);
            AllRules.Add(28, rule28);
            AllRules.Add(30, rule30);
            AllRules.Add(50, rule50);
            AllRules.Add(69, rule69); //nice
            AllRules.Add(165, rule165);
        }

        public void SetSelectedRule(int value)
        {
            currentRule = value;
        }

        public List<int> GetAvaliableRules()
        {
            List<int> rules = new List<int>();

            for (int i = 0; i < 256; i++)
            {
                if (AllRules.ContainsKey(i))
                {
                    rules.Add(i);
                }
            }

            return rules;
        }

        public int[] Advance(int[] _currentCells)
        {
            AllRules.TryGetValue(currentRule, out selectedRule);

            currentCells = _currentCells;
            newCells = new int[size];

            for (int i = 0; i < size; i++)
            {
                State currentState = new State(
                    currentCells[(i - 1 + size) % size],
                    currentCells[i],
                    currentCells[(i + 1 + size) % size]
                    );

                newCells[i] = selectedRule[currentState.GetState()];
            }

            return newCells;
        }
    }
}
