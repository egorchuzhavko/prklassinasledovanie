using System;

namespace prchast2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pair p = new Pair(2, 2);
            Pair p2 = new Pair(3, 4);

            System.Console.WriteLine(p.Sub(p2).ToString());
            System.Console.WriteLine(p.Equal());
            System.Console.WriteLine(p.Multiply());

            System.Console.WriteLine();
            Rational p3 = new Rational(1, 4);
            Rational p4 = new Rational(3, 4);

            System.Console.WriteLine(p3.Sub(p4).ToString());
            System.Console.WriteLine(p3.Equal());
            System.Console.WriteLine(p3.Multiply(p4));
            System.Console.WriteLine(p3.Multiply());

            Pair pp = new Rational(1, 4);
            Pair pp2 = new Rational(1, 4);

            System.Console.WriteLine();

            System.Console.WriteLine(pp.Sub(p4).ToString());
            System.Console.WriteLine((pp as Rational).Sub(p4).ToString());
            System.Console.WriteLine(((Rational)pp).Sum(pp2 as Rational).ToString());
            System.Console.WriteLine(pp.Multiply().ToString());
        }
    }
}
