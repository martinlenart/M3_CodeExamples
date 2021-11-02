using System;

namespace ColoredSpots
{
    class Program
    {
        static void Main(string[] args)
        {
            var coloredSpots = new ColoredSpots(100);
            Console.WriteLine(coloredSpots);

            coloredSpots.Sort();
            Console.WriteLine(coloredSpots);

            for (SpotColor col = SpotColor.Red; col <= SpotColor.White; col++)
            {
                Console.WriteLine($"There are {coloredSpots.Count(col)} {col} spots");
            }

        }
    }
}
