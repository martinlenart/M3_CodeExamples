using System;

namespace ChefHerititage
{
    public class Chef
    {
        public string Name { get; set; }
    }
    public class FrenchChef : Chef
    {
        public string Hello => "Bonjour";
        public override string ToString() => $"{Hello} {Name}";

        public FrenchChef(string name)
        {
            Name = name;
        }
    }
    public class ItalianChef : Chef
    {
        public string Hello => "Ciao";
        public override string ToString() => $"{Hello} {Name}";
    }
    public class SwedishChef : Chef
    {
        public string Hello => "Hej";
        public string StringToPrint => $"{Hello} {Name}";
        class Program
    {
        static void Main(string[] args)
        {
            FrenchChef chef1 = new FrenchChef("Jean-Pierre");
            ItalianChef chef2 = new ItalianChef { Name = "Mario" };
            SwedishChef chef3 = new SwedishChef { Name = "Pelle" };
            

            Console.WriteLine(chef1);
            Console.WriteLine(chef2);
            Console.WriteLine(chef3.StringToPrint);
        }
    }
}
