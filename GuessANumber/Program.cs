using System;

namespace GuessANumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"\nLet's play guess-a-secret-number:");

            string playerName = null;
            int nrRounds = 0;
            bool PlayGame = TryReadName(out playerName) &&
                            TryReadNrOfRounds(out nrRounds);

            if (PlayGame)
            {
                Console.WriteLine($"Hello {playerName}, lets play {nrRounds} rounds");
            }

            bool correctGuess = false;
            int secretNumber = new Random().Next(1, 11);
            
            int round = 0;
            while (PlayGame && round < nrRounds)
            {
                Console.WriteLine($"\nPlaying round nr {round + 1}");
                Console.WriteLine($"------------------");

                PlayGame = TryReadGuess(out int myGuess);
                if (!PlayGame)
                    break;

                correctGuess = CorrectGuess(secretNumber, myGuess);
                if (correctGuess)
                {
                    PlayGame = !correctGuess;
                    Console.WriteLine($"You guessed the number in {round+1} tries");
                }

                round++;
            }

            if (round > 0 && !correctGuess)
            {
                Console.WriteLine($"\n{playerName}, Sorry you could not guess the number, which was {secretNumber}");
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
        private static bool TryReadGuess(out int Guess)
        {
            Guess = 0;
            string sInput;
            do
            {
                Console.WriteLine("Enter a number (1-10 or Q to quit)?");
                sInput = Console.ReadLine();
                if (int.TryParse(sInput, out Guess) && Guess >= 1 && Guess <= 10)
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
        public static bool CorrectGuess(int secretNr, int myGuess)
        {
            if (secretNr < myGuess)
            {
                Console.WriteLine($"Secret number is smaller than yours");
                return false;
            }

            if (secretNr > myGuess)
            {
                Console.WriteLine($"Secret number is larger than yours");
                return false;
            }
 
            Console.WriteLine($"You guessed the right number");
            return true;
        }
        #endregion
    }
}
