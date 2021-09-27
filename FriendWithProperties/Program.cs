using System;

namespace FriendWithProperties
{
    public enum FriendLevel
    {
        Normal, Good, Family, BestFriend 
    }
    public class Friend
    {
        public string Name { get; set; }
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
        }
    }
}
