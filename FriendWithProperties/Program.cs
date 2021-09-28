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

            Friend aFamilyMember = new Friend(FriendLevel.Family);
            Console.WriteLine(aFamilyMember.Name);
        }
    }
}
//Group Exercise
//1.    Create a constructor that takes one parameter, Level, of type FriendLevel. In the Constructor
//      use a switch-case construct to initialize  Name, PhoneNr, Level and BirthDay of a person you know
//      of that particular FriendLevel
