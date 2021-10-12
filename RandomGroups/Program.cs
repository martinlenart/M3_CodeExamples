using System;

namespace RandomGroups
{
    class Program
    {
        
        static void Main(string[] args)
        {
            StudentList myStudents = new StudentList();
            Console.WriteLine("Empty student list");
            Console.WriteLine(myStudents);

            Console.WriteLine("\nStudent list");
            myStudents.InitiateOOP1dotNet5();
            Console.WriteLine(myStudents);

            Console.WriteLine("\nSorted student list");
            myStudents.Sort();
            Console.WriteLine(myStudents);
        }
    }

    //Sprint 1
    //1. Properties and Methods of class StudentList
    //2. How do I keep track of NrOfStudents
    //3. How do I initiate students in InitiateOOP1dotNet5()
    //4. What changes do I need to make in "Selection Sort" From BOOP_05_07 to implement Sort()
}
