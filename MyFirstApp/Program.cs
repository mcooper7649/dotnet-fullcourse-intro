using System;
using System.Collections;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)

        {

            var friends = new List<string> { "Frank", "Joe", "Michelle", "Andy", "Maria", "Carlos", "Angelica" };
            var partyFriends = GetPartyFriends(friends, 3);

            foreach (var name in partyFriends)
                Console.WriteLine(name);
        }

        public static List<string> GetPartyFriends(List<string> list, int count)
        {

            if (list == null)
                throw new ArgumentNullException("List", "This list is empty");
            if (count > list.Count)
                throw new ArgumentOutOfRangeException("Count", "Count cannot be greater than elements in the list.");
            var buffer = new List<string>(list);
            var partyFriends = new List<string>();
            while (partyFriends.Count < count)
            {
                var currentFriend = GetPartyFriend(list);
                partyFriends.Add(currentFriend);
                list.Remove(currentFriend);
            }
            return partyFriends;
        }

        public static string GetPartyFriend(List<string> List)
        {
            string shortestName = List[0];
            for (var i = 0; i < List.Count; i++)
            {
                if (List[i].Length < shortestName.Length)
                {
                    shortestName = List[i];
                }
            }
            return shortestName;
        }
    }

}