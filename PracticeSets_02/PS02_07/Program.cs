using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS02_07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            *Write a program that takes an array of numbers as input and outputs the sum of the numbers. 
            */
            Console.WriteLine("Enter numbers separated by spaces:");

            
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            int sum = 0;

            foreach (string number in numbers)
            {
                
                if (int.TryParse(number, out int num))
                {
                    sum += num;
                }
                
            }

            Console.WriteLine($"The sum of the numbers is: {sum}");
        }
    }
}
