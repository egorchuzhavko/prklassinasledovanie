using System;
using System.Collections.Generic;
using System.Text;

namespace prchast1
{
    class Y : X
    {
        private int y;

        public Y(int x1, int x2, int y) : base(x1, x2)
        {
            this.y = y;
        }

        public int GetY() { return y; }
        public void SetY(int y) { this.y = y; }

        public void Run()
        {
            Console.WriteLine($"Сумма квадратов всех чисел: {Math.Pow(y, 2) + Math.Pow(GetX2(), 2) + Math.Pow(GetX1(), 2)}");
        }
    }
}
