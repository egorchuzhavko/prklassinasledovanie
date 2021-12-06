using System;
using System.Threading.Channels;

namespace Nasledovanieraznihklassov
{
    public class Worker : Staff
    {
        private bool isVersatile;

        public Worker(string name, string workstatus, int workexp, bool isVersatile) : base(name, workstatus, workexp)
        {
            this.isVersatile = isVersatile;
        }

        public void VersatileCheck()
        {
            Console.WriteLine($"{name} " + (isVersatile ? $"is versatile" : "is not versatile"));
        }
    }
}