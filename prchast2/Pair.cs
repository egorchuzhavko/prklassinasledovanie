using System;
using System.Collections.Generic;
using System.Text;

namespace prchast2
{
    class Pair
    {
        protected int first;
        protected int second;

        public int First
        {
            get { return first; }
            set { this.first = value; }
        }

        public int Second
        {
            get { return second; }
            set{ this.second = value; }
        }

        public Pair(int first, int second)
        {
            this.first = first;
            this.second = second;
        }

        public bool Equal()
        {
            if (this.first == this.second)
            {
                return true;
            }
            return false;
        }

        public int Multiply() { return this.first * this.second; }
        public virtual Pair Sub(Pair p)
        {
            Pair a = new Pair(this.first - this.second, p.first - p.second);
            return a;
        }

        public override string ToString() { return $"{this.First},{this.Second}"; }
    }
}
