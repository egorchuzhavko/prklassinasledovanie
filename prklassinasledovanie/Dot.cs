using System;
using System.Collections.Generic;
using System.Text;

namespace prchast1
{
    class Dot : Figure
    {
        private double x;
        private double y;

        public Dot() { }
        public Dot(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void SetX(double x){ this.x = x; }
        public void SetY(double y) { this.y = y; }
        public double GetX() { return x; }
        public double GetY() { return y; }
        public override double Square() {
            return 0;
        }

    }
}
