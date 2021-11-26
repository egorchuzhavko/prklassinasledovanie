using System;
using System.Collections.Generic;
using System.Text;

namespace prchast1
{
    class X
    {
        private int x1;
        private int x2;

        public X(int x1, int x2)
        {
            this.x1 = x1;
            this.x2 = x2;
        }
        
        public X() { }

        public void SetX1(int x1) { this.x1 = x1; }
        public void SetX2(int x2) { this.x2 = x2; }

        public int GetX1() { return x1; }
        public int GetX2() { return x2; }
    }
}
