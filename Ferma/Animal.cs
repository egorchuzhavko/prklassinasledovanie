namespace Ferma
{
    public abstract class Animal
    {
        public string name { get; set; }
        public int age { get; set; }

        public  Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public abstract void Walk();
        public abstract void Sleep();
        public abstract void HowOld();
    }
}