using System;

namespace Nasledovanieraznihklassov
{
    public class Librarian : Staff
    {
        private bool isWorksRN;

        public Librarian(string name, string workstatus, int workexp, bool isWorksRn) : base(name, workstatus, workexp)
        {
            isWorksRN = isWorksRn;
        }

        public void IsWorksRNStatus()
        {
            Console.WriteLine($"{name} is " + (isWorksRN ? "works" : "not works") + " right now");
        }
    }
}