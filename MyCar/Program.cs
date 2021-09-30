using System;

namespace MyCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar1 = new Car { };
            Console.WriteLine(myCar1);
    
            Car myCar2 = new Car ();
            Console.WriteLine(myCar2);

            Car myCar3 = new Car { Color = CarColor.Green };
            Console.WriteLine(myCar3);

            Car myCar4 = new Car(true);
            Console.WriteLine(myCar4);
  
            Car myCar5 = new Car(false);
            Console.WriteLine(myCar5);
        }
    }
}
