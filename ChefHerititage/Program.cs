using System;

namespace ChefHerititage
{
    public class Chef
    {
        public string Name { get; set; }
        public int Age = 0;
        public virtual string Hello => "I'm busy!";

        public virtual string FavoriteDish => "I have none";
    }
    public class FrenchChef : Chef
    {
        public new int Age;
        public override string Hello => "Bonjour";
        public override string FavoriteDish => "Escargot";
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
        public override string FavoriteDish => "Pizza";
        public override string ToString() => $"{Hello} my name is {Name}";
    }
    public class SwedishChef : Chef
    {
        public override string Hello => "Hej";
        public override string FavoriteDish => "Meatballs";
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


            Chef anyChef = new Chef { };
            Chef chef1 = new FrenchChef { Name = "Jean-Pierre" };
            FrenchChef french3 = new FrenchChef { Name = "Jean-Pierre" };


            Console.WriteLine("\nFavorite Dishes");
            MyFavoriteDish(new FrenchChef { Name = "Jean-Pierre" });
            MyFavoriteDish(new ItalianChef { Name = "Mario" });
            MyFavoriteDish(new SwedishChef { Name = "Pelle" });
            MyFavoriteDish(new Chef {});

            //FrenchChef french3 = (FrenchChef) new Chef { };     // Error
            //Console.WriteLine(french3.Hello);

        }

        public static void MyFavoriteDish(Chef myChef)
        {
            Console.WriteLine($"Hi, I'm {myChef.Name} and my favorite dish is {myChef.FavoriteDish}");
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
