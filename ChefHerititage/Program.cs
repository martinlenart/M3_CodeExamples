using System;

namespace ChefHerititage
{
    public abstract class Chef
    {
        public string Name { get; set; } = "Boring";
        public int Age = 0;
        public virtual string Hello => "I'm boring!";

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
    public sealed class ItalianChef : Chef
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
           // Chef boring = new Chef { };

            Console.WriteLine(french.Hello);
            Console.WriteLine(italian.Hello);
            Console.WriteLine(swedish.Hello);
            //Console.WriteLine(boring.Hello);


            Chef chef1 = new FrenchChef { Name = "Jean-Pierre" };
            FrenchChef french3 = new FrenchChef { Name = "Jean-Pierre" };

            //FrenchChef french3 = (FrenchChef) new Chef { };     // Error
            //Console.WriteLine(french3.Hello);

            Console.WriteLine("\nFavorite Dishes");
            MyFavoriteDish(french);
            MyFavoriteDish(italian);
            MyFavoriteDish(swedish);
            
           // MyFavoriteDish(boring);


        }

        public static string Iam (Chef myChef)
        {
            //Use a switch expression with type pattern to write
            // "Italiensk kock" if ItalianChef
            // "Fransk kock" if FrenchChef
            // "Svensk kock " if SwedishChef

            //Use type pattern with property to write
            // "Typisk Svensk kock" if SwedishChef and FavoriteDish is "Meatballs"

            //If no pattern is matched write
            // "Vet inte vilken kock"

            string sRet = myChef switch 
            { }

            return sRet;
        }

        public static void MyFavoriteDish(Chef myChef)
        {
            Console.WriteLine($"\nHi, I'm {myChef.Name} and my favorite dish is {myChef.FavoriteDish}");

            //This is valid for all children as a child is a Parent => Italian, French, Swedish chefs are all Chefs!
            if (myChef is Chef)
            {
                Console.WriteLine($"All chefs are indeed chefs");
            }

            //using "is" to identifyFrench chefs
            if (myChef is FrenchChef fc)
            {
                Console.WriteLine($"Viva La France {fc.Hello}!");
            }

            //using "as" to identify Italian chefs
            ItalianChef ic = myChef as ItalianChef;
            if (ic != null)
            {
                Console.WriteLine($"Salve {ic.Hello}!");
            }

            //using "as" to identify non Italian chefs
            ItalianChef nic = myChef as ItalianChef;
            if (nic == null)
            {
                Console.WriteLine("Non Italian");
            }

            //Write the Type of Chef regardlessif it is Chef, Italian, French, or Swedish
            Type myType = myChef.GetType();
            Console.WriteLine(myType.Name);

            //Only Chef and not a child
            if (myChef.GetType() == typeof(Chef))
            {
                Console.WriteLine("Only Chef and not French, Italian or Swedish");
            }
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
