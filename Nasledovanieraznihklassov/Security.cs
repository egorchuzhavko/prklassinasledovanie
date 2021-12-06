using System;

namespace Nasledovanieraznihklassov
{
    public class Security : Staff
    {
        private bool isNightShift;

        public Security(string name, string workstatus, int workexp, bool isNightShift) : base(name, workstatus, workexp)
        {
            this.isNightShift = isNightShift;
        }

        public void IsNightShiftCheck()
        {
            Console.WriteLine($"{name} have " + (isNightShift ? "" : "not ") + "night shift");
        }
    }
}