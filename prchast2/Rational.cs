using System;
using System.Collections.Generic;
using System.Text;

namespace prchast2
{
    class Rational : Pair
    {
        public Rational(int first, int second) : base(first, second) { }

        public Rational Sub(Rational p)
        {
            Rational a = new Rational(this.first * p.second - p.First * this.second, this.second * p.second);
            return a;
        }
        public override Pair Sub(Pair pp)
        {
            Rational p = pp as Rational;
            return new Rational(this.first * p.second - p.First * this.second, this.second * p.second); ;
        }
        public Rational Sum(Rational p)
        {
            return new Rational(this.first * p.second + p.First * this.second, this.second * p.second); ;
        }

        public Rational Multiply(Rational p)
        {
            return new Rational(this.first * p.First, this.second * p.Second);
        }

        public override string ToString() { return $"{this.First}/{this.Second}"; }
    }
}
