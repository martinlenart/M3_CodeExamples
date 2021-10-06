using System;

namespace ChefHerititage
{
    public class Chef
    {
        public string Name { get; set; }
        public int Age = 0;
        public virtual string Hello => "I'm busy!";
    }
    public class FrenchChef : Chef
    {
        public new int Age = 30;
        public override string Hello => "Bonjour";
        public override string ToString() => $"{Hello} my name is {Name}";

        public FrenchChef()
        {
            base.Age = 60;
        }
    }
    public class ItalianChef : Chef
    {
        public new string Hello => "Ciao";
        public override string ToString() => $"{Hello} my name is {Name}";
    }
    public class SwedishChef : Chef
    {
        public new string Hello => "Hej";
        public override string ToString() => $"{Hello} my name is {Name}";
    }
    class Program
    {
        static void Main(string[] args)
        {
            FrenchChef chef1 = new FrenchChef { Name = "Jean-Pierre" };
            ItalianChef chef2 = new ItalianChef { Name = "Mario" };
            SwedishChef chef3 = new SwedishChef { Name = "Pelle" };

            Console.WriteLine(chef1.Hello);
            Chef myBoss = (Chef)chef1;
            Console.WriteLine(myBoss.Hello);

            Console.WriteLine("\n\n\n");
            Console.WriteLine(chef1);
            Console.WriteLine(chef1.Age);

            Chef boss = chef1;
            Console.WriteLine(boss.Age);

            Console.WriteLine(chef2);
            Console.WriteLine(chef2.Age);
            Console.WriteLine(chef3);

            Chef masterChef = new Chef { Name = "Gordon" };
            Console.WriteLine();
            Console.WriteLine(masterChef.Name);

        }
    }
}
