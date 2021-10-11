namespace ArrayPractise
{
    #region Chef classes
    public abstract class Chef
    {
        public string Name { get; set; } = "Boring";
        public virtual string Hello => "I'm boring!";
        public virtual string FavoriteDish => "I have none";
    }
    public class FrenchChef : Chef
    {
        public override string Hello => "Bonjour";
        public override string FavoriteDish => "Escargot";
        public override string ToString() => $"{Hello} my name is {Name}";
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
    public class GermanChef : Chef
    {
        public override string Hello => "Guten Tag";
        public override string FavoriteDish => "Sourkraut";
        public override string ToString() => $"{Hello} my name is {Name}";
    }

    #endregion

    public enum DotColor { Red, Green, Blue, White, Pink }

    class Program
    {
        DotColor[,,] dotMatrix = {{{DotColor.Red, DotColor.Red, DotColor.Red },
                                   {DotColor.Red, DotColor.White, DotColor.Red },
                                   {DotColor.Red, DotColor.Red, DotColor.Red }},
                                  {{DotColor.Green, DotColor.Green, DotColor.Green },
                                   {DotColor.Green, DotColor.White, DotColor.Green },
                                   {DotColor.Green, DotColor.Green, DotColor.Green }},
                                  {{DotColor.Blue, DotColor.Blue, DotColor.Blue },
                                   {DotColor.Blue, DotColor.White, DotColor.Blue },
                                   {DotColor.Blue, DotColor.Blue, DotColor.Blue }}};

        Chef[][] chefMatrix = new[] { new Chef[] {new ItalianChef(), new ItalianChef(), new ItalianChef()},
                                      new Chef[] {new FrenchChef(), new FrenchChef()},
                                      new Chef[] {new SwedishChef()}};
        static void Main(string[] args)
        {
            //1. Loop through dotMatrix and printout the matrix. Red slice, Green slice, Blue slice
            //2. Count the number of White Dots.
            //3. Replace the White dots with Pink dots 

            //4. Loop through chefMatrix and printout using Iam to Printout the nationality of the chef
            //5. Count the number of FrenchChefs.
            //6. Replace the FrenchChef with a GermanChef
        }

        public static string Iam(Chef myChef) => myChef switch
        {
            ItalianChef => "Italienst kock ",
            FrenchChef => "Fransk kock ",
            SwedishChef => "Svensk kock ",
            GermanChef => "Tysk kock ",
            _ => "Vet inte vilken kock"
        };
    }
}
