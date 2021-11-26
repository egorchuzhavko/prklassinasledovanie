using System;
using System.Collections.Generic;
using System.Text;

namespace prchast2
{
    class Pair
    {
        protected int first;
        protected int second;
        public Pair(int first, int second)
        {
            this.first = first;
            this.second = second;
        }
        public bool Equal()
        {
            if (first == second)
                return true;
            else
                return false;
        }
        public int Mul() { return first * second; }

        public int Sub() { return first - second; }
    }
}
