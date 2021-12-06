using System;

namespace Nasledovanieraznihklassov
{
    public class Cashier : Staff
    {
        private bool isMainCashier;

        public Cashier(string name, string workstatus, int workexp, bool isMainCashier) : base(name, workstatus, workexp)
        {
            this.isMainCashier = isMainCashier;
        }

        public void IsMainCashierCheck()
        {
            Console.WriteLine($"{name} is" + (isMainCashier ? " " : " not") + " main cashier");
        }
    }
}