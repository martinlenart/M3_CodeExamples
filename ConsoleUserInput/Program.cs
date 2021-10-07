using System;

namespace ConsoleUserInput
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"\nLet's get some user input and play some game rounds:");

            string playerName = null;
            int nrRounds = 0;
            bool PlayGame = TryReadName(out playerName) &&
                            TryReadNrOfRounds(out nrRounds);
            
            if (PlayGame)
            {
                Console.WriteLine($"Hello {playerName}, lets play {nrRounds} rounds");
            }
            
            int round = 0;
            while (PlayGame && round < nrRounds)
            {
                Console.WriteLine($"\nPlaying round nr {round + 1}");
                Console.WriteLine($"------------------");

                PlayGame = TryReadNumber(out int myNumber);
                if (!PlayGame)
                    break;


                OnePartOfGame();
                AnotherPartOfGame();
                
                round++;
            }

            if (nrRounds > 0)
            {
                Console.WriteLine($"\n{playerName}, this was great, wasn't it?");
            }
        }

        #region User Input
        private static bool TryReadName(out string playerName)
        {
            playerName = null;

            Console.WriteLine("What is your name (Empty to quit)?");
            string sInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(sInput) && !string.IsNullOrWhiteSpace(sInput))
            {
                playerName = sInput;
                return true;
            }

            return false;
        }
        private static bool TryReadNrOfRounds(out int NrOfRounds)
        {
            NrOfRounds = 0;
            string sInput;
            do
            {
                Console.WriteLine("How many rounds should we play (1-5 or Q to quit)?");
                sInput = Console.ReadLine();
                if (int.TryParse(sInput, out NrOfRounds) && NrOfRounds >= 1 && NrOfRounds <= 5)
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

        #region Game Playing
        public static void OnePartOfGame()
        {
            Console.WriteLine($"I am now playing one part of the game...");
        }
        public static void AnotherPartOfGame()
        {
            Console.WriteLine($"I am now playing another part of the game...");
        }
        #endregion
    }
}
