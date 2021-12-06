using System;

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

            human[] mas = new human[8];
            mas[0] = new Student("Kam", "Student", 3);
            mas[0].WorkStatus();
            mas[1] = new Staff("Petr", "Freelanser", 3);
            mas[1].WorkStatus();
            mas[1].WorkExperience();
        }
    }
}