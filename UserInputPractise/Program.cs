using System;

namespace UserInputPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Try pattern for user input from console!\n");

            string YourName = null, FathersName = null, MothersName = null;
            int NrSiblings = 0, NrCousins = 0;

            bool Continue = TryReadYourName(out YourName) &&
                            TryReadFathersName(out FathersName) &&
                            TryReadMothersName(out MothersName);

            // Terminate if Quit
            if (!Continue) return;

            Console.WriteLine($"\nHi {YourName}. Your father's name is {FathersName} and your mother's name is {MothersName}");

            Continue = TryReadNrSiblings(out NrSiblings) &&
                       TryReadNrCousins(out NrCousins);

            // Terminate if Quit
            if (!Continue) return;

            Console.WriteLine($"\nYou have {NrSiblings} brothers and sisters and {NrCousins} cousins");

        }

        #region Try pattern for User Console input
        private static bool TryReadYourName(out string YourName)
        {
            YourName = null;

            Console.WriteLine("What is your name (Empty to quit)?");
            string sInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(sInput) && !string.IsNullOrWhiteSpace(sInput))
            {
                YourName = sInput;
                return true;
            }

            return false;
        }
        private static bool TryReadFathersName(out string FathersName)
        {
            FathersName = null;

            Console.WriteLine("What is your father's name (Empty to quit)?");
            string sInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(sInput) && !string.IsNullOrWhiteSpace(sInput))
            {
                FathersName = sInput;
                return true;
            }

            return false;
        }
        private static bool TryReadMothersName(out string MothersName)
        {
            MothersName = null;

            Console.WriteLine("What is your mother's name (Empty to quit)?");
            string sInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(sInput) && !string.IsNullOrWhiteSpace(sInput))
            {
                MothersName = sInput;
                return true;
            }

            return false;
        }
        private static bool TryReadNrSiblings(out int NrSiblings)
        {
            NrSiblings = 0;
            string sInput;
            do
            {
                Console.WriteLine("How many brothers and sisters do you have (0-20 or Q to quit)?");
                sInput = Console.ReadLine();
                if (int.TryParse(sInput, out NrSiblings) && NrSiblings >= 0 && NrSiblings <= 20)
                {
                    return true;
                }
                else if (sInput != "Q" && sInput != "q")
                {
                    Console.WriteLine("Wrong input, please try again.");
                }
            }
            while ((sInput != "Q" && sInput != "q"));
            return false;
        }
        private static bool TryReadNrCousins(out int NrCousings)
        {
            NrCousings = 0;
            string sInput;
            do
            {
                Console.WriteLine("How many cousins do you have (0-200 or Q to quit)?");
                sInput = Console.ReadLine();
                if (int.TryParse(sInput, out NrCousings) && NrCousings >= 0 && NrCousings <= 200)
                {
                    return true;
                }
                else if (sInput != "Q" && sInput != "q")
                {
                    Console.WriteLine("Wrong input, please try again.");
                }
            }
            while ((sInput != "Q" && sInput != "q"));
            return false;
        }
        #endregion
    }
}
//Exercises
//1. Look at the 5 Try methods and identify similarities. Reduce the nr of Methods using DRY
//2. Create a TryReadDateTime(...) and ask the user for birthdate using the Try pattern
