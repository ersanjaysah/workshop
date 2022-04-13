using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayWorkshop
{
    public class AnagramCheck
    {
        public static void CheckAnagram()
        {
            Console.WriteLine("Enter the first string:");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter the second string");
            string str2 = Console.ReadLine();

            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str1.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1==val2)
            {
                Console.WriteLine("Both the string are anagram");
            }
            else
            {
                Console.WriteLine("Both the string are not Anagram");
            }
        }
    }
}
