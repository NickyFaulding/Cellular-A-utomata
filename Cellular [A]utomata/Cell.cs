using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellular__A_utomata
{
    class Cell
    {
        private int state = 0; //0 = dead & 1 = live
                                //add more numbers to mean diferent colours?

        public int State
        {
            get { return state; }
            set { state = value; }
        }
    }
}
