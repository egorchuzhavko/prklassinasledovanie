using System;
using System.Threading.Channels;

namespace Nasledovanieraznihklassov
{
    public class Staff : Human
    {
        protected int workexp;

        public Staff(string name, string workstatus, int workexp) : base(name, workstatus)
        {
            this.workexp = workexp;
        }

        public override void WorkStatus()
        {
            Console.WriteLine($"{name} is {workstatus}");
        }

        public void WorkExperience()
        {
            Console.WriteLine($"{name} has work experience is about {workexp}");
        }
    }
}