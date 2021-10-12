using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int mySecretNr = 15;

            int EncryptionKey = CreateEncryptionKey(mySecretNr);
            int Key2 = CreateEncryptionKey(3, out int myRandomKey);

            Console.WriteLine(myRandomKey);
        }

        public static int CreateEncryptionKey(int Seed)
        {
            var rnd = new Random();
            return Seed + rnd.Next(10, 100);
        }
        public static int CreateEncryptionKey (int Seed, out int rndKey)
        {
            var rnd = new Random();
            rndKey = rnd.Next(10, 100);
            return Seed + rndKey;
        }
    }
}
