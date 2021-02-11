using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {

            // Arrays 
            int[] numArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            string[] names = new string[] { "Tim", "Martin", "Nikki", "Sara" };

            bool[] tfArray = { true, false, true, false, true, false, true, false, true, false, true };

            // Generic Lists
            List<string> flavors = new List<string>();
            flavors.Add("vanilla");
            flavors.Add("chocolate");
            flavors.Add("cherry");
            flavors.Add("raspberry");
            flavors.Add("coffee");

            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);

            flavors.Remove("cherry");
            Console.WriteLine(flavors.Count);


            // Create a dictionary that will store both string keys as well as string values
            Dictionary<string, string> profile = new Dictionary<string, string>();

            // Add key/value pairs to this dictionary where:
            // each key is a name from your names array
            // each value is a randomly select a flavor from your flavors list.
            // profile.Add(names[0], flavors[0]);

            Random rand = new Random();
            int myInt;

            // for (int i = 0; i < names.Length; i++)
            // {
            //     myInt = rand.Next(flavors.Count);
            //     profile.Add(names[i], flavors[myInt]);
            // }


            foreach (String name in names)
            {
                myInt = rand.Next(flavors.Count);
                profile.Add(name, flavors[myInt]);
            }

            // Loop through the dictionary and print out each user's name and their associated ice cream flavor

            foreach (var x in profile)
            {
                Console.WriteLine(x.Key + "-" + x.Value);
            }

        }
    }
}
