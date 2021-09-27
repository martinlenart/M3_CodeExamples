using System;

namespace M3_CodeExamples
{
    public class Stock
    {
        public string Name { get; init; }

        private decimal currentPrice = 1;
        public decimal CurrentPrice
        {
            get { return currentPrice; }
            set
            {
                if (value > 0)
                    currentPrice = value;
                else
                    throw new Exception("Cannot have price 0");
            }
        }
        public int SharesOwned { get; set; }
        public decimal Worth
        {
            get { return CurrentPrice * SharesOwned; }
        }

        public string StringToPrint
        {
            get
            {
                return $"Aktie {Name} har pris {CurrentPrice}.  Jag har {SharesOwned} aktier till ett värde {Worth}";
            }
         }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Stock s1 = new Stock
            {
                Name = "SAS",
                CurrentPrice = 2.00M,
                SharesOwned = 50
            };

            s1.CurrentPrice = 0M;
            Console.WriteLine(s1.StringToPrint);
            Console.WriteLine(s1.SharesOwned);
            Console.WriteLine(s1.Worth);

        }

    }
}
