using System;

namespace ChefHerititage
{
    public class Chef
    {
        public string Name { get; set; }
        public int Age = 0;
        public virtual string Hello => "I'm busy!";

        public string FavoriteDish => "I have none";
    }
    public class FrenchChef : Chef
    {
        public new int Age;
        public override string Hello => "Bonjour";
        public override string ToString() => $"{Hello} my name is {Name}";

        public int Salary;

        public FrenchChef()
        {
            base.Age = 35;
            this.Age = 20;
        }
    }
    public class ItalianChef : Chef
    {
        public override string Hello => "Ciao";
        public override string ToString() => $"{Hello} my name is {Name}";
    }
    public class SwedishChef : Chef
    {
        public override string Hello => "Hej";
        public override string ToString() => $"{Hello} my name is {Name}";
    }
    class Program
    {
        static void Main(string[] args)
        {
            FrenchChef french = new FrenchChef { Name = "Jean-Pierre" };
            ItalianChef italian = new ItalianChef { Name = "Mario" };
            SwedishChef swedish = new SwedishChef { Name = "Pelle" };

            Console.WriteLine(french.Hello);
            Console.WriteLine(italian.Hello);
            Console.WriteLine(swedish.Hello);

            Console.WriteLine();

            Chef anyChef = new Chef { };
            Chef chef1 = new FrenchChef { Name = "Jean-Pierre" };
            FrenchChef french3 = new FrenchChef { Name = "Jean-Pierre" };
            
            SayHello(chef1);
            MyFavoriteDish(chef1);

            //FrenchChef french3 = (FrenchChef) new Chef { };     // Error
            //Console.WriteLine(french3.Hello);

        }

        public static void MyFavoriteDish(Chef myChef)
        {
            Console.WriteLine(myChef.Hello);
        }

        public static void SayHello (Chef myChef)
        {
            Console.WriteLine(myChef.Hello);
        }
        public static void SayHello1(FrenchChef myChef)
        {
            Console.WriteLine(myChef.Hello);
        }

    }
}
