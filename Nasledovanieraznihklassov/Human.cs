namespace Nasledovanieraznihklassov
{
    public abstract class Human
    {
        protected string name;
        protected string workstatus;

        protected Human(string name, string workstatus)
        {
            this.name = name;
            this.workstatus = workstatus;
        }

        public abstract void WorkStatus();
    }
}