using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PS02_04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Write a program that takes a string as input and outputs whether it is a palindrome. 
            */
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            if (IsPalindrome(input))
            {
                Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome.");
            }
        }

        static bool IsPalindrome(string s)
        {
            string cleaned = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower();

            return cleaned == Reverse(cleaned);
        }

        static string Reverse(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }

}
