using System;
using System.Collections.Generic;
using System.Text;

namespace prchast1
{
    class Circle : Dot
    {
        private double x1;
        private double y1;

        public Circle() { }
        public Circle(double x, double y, double x1,double y1) : base(x, y)
        {
            this.x1 = x1;
            this.y1 = y1;
        }
        public override double Square()
        {
            return Math.PI * Math.Pow(Math.Sqrt(Math.Pow(x1 - GetX(), 2) + Math.Pow(y1 - GetY(), 2)), 2);
        }
    }
}
