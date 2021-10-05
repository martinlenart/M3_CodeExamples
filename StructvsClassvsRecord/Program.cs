using System;

namespace StructvsClassvsRecord
{
    struct structA
    {
        public int myInt { get; set; }
    }
    class classA
    {
        public int myInt { get; set; }

        public classA() { }
        
        //Copy constructor
        public classA (classA tobeCopied)
        {
            myInt = tobeCopied.myInt;
        }
    }
    record recordA(int myInt);

    class Program
    {
        static void Main(string[] args)
        {
            structA mainStruct = new structA { myInt = 10 };
            classA mainClass = new classA { myInt = 10 };
            recordA mainRecord = new recordA (10);

            SetAValue(mainStruct, mainClass, mainRecord);

            Console.WriteLine(mainStruct.myInt);
            Console.WriteLine(mainClass.myInt);
            Console.WriteLine(mainRecord.myInt);
        }

        static void SetAValue(structA myStruct, classA myClass, recordA myRecord)
        {
            classA myClassDeepCopied = new classA(myClass);
            myStruct.myInt = 5;
            myClassDeepCopied.myInt = 5;

            //myRecord.myInt = 5; //Cannot change it as it is immutable
            recordA myRecordDeepCopied = myRecord with { myInt = 5 };  // Simple to make deep copy on record with some modifications
        }
    }
}
