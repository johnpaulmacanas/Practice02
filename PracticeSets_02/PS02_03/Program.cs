using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            *Write a program that takes a character as input and outputs whether it is a vowel or a consonant.  
            */
            Console.WriteLine("Enter a single character:");
            string input = Console.ReadLine();

            if (input.Length > 0)
            {
                char character = input[0];

                if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                {
                    Console.WriteLine("The character is a vowel.");
                }
                else if (character >= 'a' && character <= 'z')
                {
                    Console.WriteLine("The character is a consonant.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a lowercase letter.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a letter.");
            }
        }
    }
}
