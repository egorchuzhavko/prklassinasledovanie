using System;
using System.Collections.Generic;
using System.Text;

namespace prchast2
{
    class Rational : Pair
    { 
        public Rational(int first, int second): base(first, second) { }
        public int Sub(Rational p)
        {
            if (this.second == p.second)
            {
                return this.first - p.first;
            }
            else
            {
                return 0;
            }
        }

        public int Sum(Rational p)
        {
            if (this.second == p.second)
            {
                return this.first + p.first;
            }
            return 0;
        }

        public string Multiply(Rational p)
        {
            return $"{this.first * p.first}/{this.second * p.second}";
        }

    }
}
