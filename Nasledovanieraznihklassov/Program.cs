using System;
using System.Threading.Channels;

namespace Nasledovanieraznihklassov
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = {"computer", "table", "chair"};
            WorkSpace ws = new WorkSpace(true, items, true);
            ws.OpinionAboutBeauty();
            ws.OpinionAboutWorkSpace();
            Console.WriteLine();
            var std = new Student("Kam", "Student", 3);
            std.WorkStatus();
            Console.WriteLine();
            var zxc = new Staff("Petr", "Freelanser", 3);
            zxc.WorkStatus();
            zxc.WorkExperience();
            Console.WriteLine();
            var emp = new Employee("Vadim", "analyst", 4, 4000);
            emp.SalaryStatus();
            emp.WorkExperience();
            emp.WorkStatus();
            Console.WriteLine();
            var wrkr = new Worker("Dizzi", "worker", 1, true);
            wrkr.VersatileCheck();
            wrkr.WorkExperience();
            wrkr.WorkStatus();
            Console.WriteLine();
            var lbrrn = new Librarian("April", "librarian", 10, false);
            lbrrn.IsWorksRNStatus();
            lbrrn.WorkExperience();
            lbrrn.WorkStatus();
            Console.WriteLine();
            var director = new Director("Daniil", "Director", 5, 100000);
            director.EarningsCheck();
            director.WorkExperience();
            director.WorkStatus();
            var security = new Security("Sasha", "Security", 2, false);
            security.IsNightShiftCheck();
            security.WorkExperience();
            security.WorkStatus();
            Console.WriteLine();
            var cashier = new Cashier("Luna", "Cashier", 6, true);
            cashier.IsMainCashierCheck();
            cashier.WorkExperience();
            cashier.WorkStatus();
        }
    }
}