using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellular__A_utomata
{
    class CA_Rule_Code
    {
        private const int size = 30;

        private int[] currentCells;
        private int[] newCells;

        private int currentRule = 1;

        Dictionary<int, int[]> Rules = new Dictionary<int, int[]>();

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

        public CA_Rule_Code()
        {
            Rules.Add(1, rule01);
            Rules.Add(2, rule02);
            Rules.Add(3, rule03);
            Rules.Add(4, rule04);
            Rules.Add(5, rule05);
            Rules.Add(6, rule06);
            Rules.Add(7, rule07);
            Rules.Add(8, rule08);
            Rules.Add(9, rule09);
            Rules.Add(10, rule10);

            Rules.Add(18, rule18);
            Rules.Add(28, rule28);
            Rules.Add(30, rule30);
            Rules.Add(50, rule50);
            Rules.Add(69, rule69); //nice
            Rules.Add(165, rule165);
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
                if (Rules.ContainsKey(i))
                {
                    rules.Add(i);
                }
            }

            return rules;
        }

        public int[] Advance(int[] _currentCells)
        {
            Rules.TryGetValue(currentRule, out selectedRule);
                       
            currentCells = _currentCells;
            newCells = new int[size];

            for (int i = 0; i < size; i++)
            {
                int left = currentCells[(i - 1 + size) % size];
                int current = currentCells[i];
                int right = currentCells[(i + 1 + size) % size];
                newCells[i] = CheckRule(left, current, right);
            }

            return newCells;
        }

        public int CheckRule(int left, int current, int right)
        {
            int newState = 0;

            if(left == 1 && current == 1 && right == 1)
            {
                newState = selectedRule[0];
            }

            else if (left == 1 && current == 1 && right == 0)
            {
                newState = selectedRule[1];
            }

            else if (left == 1 && current == 0 && right == 1)
            {
                newState = selectedRule[2];
            }

            else if (left == 1 && current == 0 && right == 0)
            {
                newState = selectedRule[3];
            }

            else if (left == 0 && current == 1 && right == 1)
            {
                newState = selectedRule[4];
            }

            else if (left == 0 && current == 1 && right == 0)
            {
                newState = selectedRule[5];
            }

            else if (left == 0 && current == 0 && right == 1)
            {
                newState = selectedRule[6];
            }

            else if (left == 0 && current == 0 && right == 0)
            {
                newState = selectedRule[7];
            }

            return newState;
        }
    }
}
