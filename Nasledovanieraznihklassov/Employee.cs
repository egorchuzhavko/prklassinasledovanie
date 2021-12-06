using System;

namespace Nasledovanieraznihklassov
{
    public class Employee : Staff
    {
        private decimal salary;

        public Employee(string name, string workstatus, int workexp, decimal salary) : base(name, workstatus, workexp)
        {
            this.salary = salary;
        }

        public void SalaryStatus()
        {
            Console.WriteLine($"{name}'s salary is about {salary}");
        }
    }
}