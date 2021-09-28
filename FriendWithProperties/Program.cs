using System;

namespace FriendWithProperties
{
    public enum FriendLevel
    {
        Friend, ClassMate, Family, BestFriend 
    }
    public class Friend
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (value != null && value != "")
                    _name = value;
                else
                    throw new Exception("Felaktigt namn");
            }
        }
        public string PhoneNr { get; set; }
        public FriendLevel Level { get; init; }
        public DateTime BirthDay { get; init; }

        public Friend() { }
        public Friend(FriendLevel friendLevel)
        {
            switch (friendLevel)
            {
                case FriendLevel.Friend:
                    Name = "John";
                    PhoneNr = "(123) 12345";
                    Level = friendLevel;
                    BirthDay = DateTime.Parse("1990-01-01");
                    break;               
                case FriendLevel.ClassMate:
                    Name = "Peter";
                    PhoneNr = "(123) 12345";
                    Level = friendLevel;
                    BirthDay = DateTime.Parse("1995-01-01");
                    break;
                case FriendLevel.Family:
                    Name = "Fido the puppy";
                    PhoneNr = "(123) 12345";
                    Level = friendLevel;
                    BirthDay = DateTime.Parse("2020-01-01");
                    break;
                case FriendLevel.BestFriend:
                    Name = "Alice";
                    PhoneNr = "(123) 12345";
                    Level = friendLevel;
                    BirthDay = DateTime.Parse("2020-01-01");
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Friend friend1 = new Friend
            {
                Name = "John",
                PhoneNr = "0756 123 45",
                BirthDay = DateTime.Parse("1990-01-01"),
                Level = FriendLevel.BestFriend
            };

            friend1.Name = "Mary";
            Console.WriteLine(friend1.Name);

            //friend1.Name = null;    //Exception
            //friend1.Name = "";      //Exception

            //Exercise 1
            Friend myBestFriend = new Friend(FriendLevel.BestFriend);
            Console.WriteLine(myBestFriend.Name);

            Friend aFamilyMember1 = new Friend(FriendLevel.Family);
            Console.WriteLine(aFamilyMember1.Name);

            Friend aFamilyMember2 = new Friend(FriendLevel.Family);
            Console.WriteLine(aFamilyMember1 == aFamilyMember2);
        }
    }
}
//Group Exercise
//1.    Create a constructor that takes one parameter, Level, of type FriendLevel. In the Constructor
//      use a switch-case construct to initialize  Name, PhoneNr, Level and BirthDay of a person you know
//      of that particular FriendLevel
//2.    Overload operators == and != to decide if two objects of class Friends are equal.
