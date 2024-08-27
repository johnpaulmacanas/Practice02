using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS02_05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            *Write a program that takes a string as input and outputs the frequency of each character in the string. 
            */
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            Dictionary<char, int> frequency = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (frequency.ContainsKey(c))
                {
                    frequency[c]++;
                }
                else
                {
                    frequency[c] = 1;
                }
            }

            Console.WriteLine("Character frequencies:");
            foreach (var pair in frequency)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
