using System;

namespace Nasledovanieraznihklassov
{
    public class Director : Staff
    {
        private decimal earnings;

        public Director(string name, string workstatus, int workexp, decimal earnings) : base(name, workstatus, workexp)
        {
            this.earnings = earnings;
        }

        public void EarningsCheck()
        {
            Console.WriteLine($"{name}'s earnings are {earnings}");
        }
    }
}