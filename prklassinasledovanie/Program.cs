using System;

namespace prchast1
{
    class Program
    {
        static void Main(string[] args)
        {
            Y y = new Y(3, 2, 2);
            y.Run();
            Console.WriteLine();
            Circle circle = new Circle(0, 0, 4, 3);
            Console.WriteLine($"Площадь круга = {circle.Square():f3}");
        }
    }
}
