using System;

namespace prchast2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pair p = new Pair(5, 2);
            Pair p1 = new Pair(3, 5);
            Console.WriteLine("Равна ли пара чисел: " + p.Equal());
            Console.WriteLine("Вычитание первой пары чисел: "+p.Sub());
            Console.WriteLine("Умножение 2 пары чисел: " + p1.Mul());
        }
    }
}
