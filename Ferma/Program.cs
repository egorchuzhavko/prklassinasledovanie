using System;

namespace Ferma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] mas = new Animal[2];
            mas[0] = new Cow("Муся", 3);
            mas[1] = new Sheep("Саша", 5);
            foreach (var item in mas)
            {
                item.Sleep();
                item.Walk();
                item.HowOld();
                Console.WriteLine("\n");
            }
        }
    }
}