using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjecetCalculator
{
    class Calculator : MyCalclutor
    {
        public int Plus(int Number1, int Number2)
        {
            return Number1 + Number2;
        }

        public int Mines(int Number1, int Number2)
        {
            return Number1 - Number2;
        }

        public int Multiplay(int Number1, int Number2)
        {
            return Number1 * Number2;
        }

        public int Divid(int Number1, int Number2)
        {
            return Number1 / Number2;
        }
    }
}
