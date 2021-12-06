using System;

namespace Nasledovanieraznihklassov
{
    public class Student : Human
    {
        private int course;

        public Student(string name, string workstatus, int course) : base(name, workstatus)
        {
            this.course = course;
        }

        public override void WorkStatus()
        {
            Console.WriteLine($"{name} is a student of {course} course");
        }
    }
}