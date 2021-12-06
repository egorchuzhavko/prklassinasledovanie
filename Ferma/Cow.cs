using System;
using System.Security.Cryptography;

namespace Ferma
{
    public class Cow : Animal
    {
        public Cow(string name,int age):base(name,age) {}

        public override void Walk()
        {
            Console.WriteLine($"{name} is walking right now");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{name} is sleeping right now");
        }

        public override void HowOld()
        {
            Console.WriteLine($"{name} is {age} years old");
        }
    }
}