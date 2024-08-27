using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS02_06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Write a program that takes a number as input and outputs the sum of its digits. 
            */
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int sum = 0;

            if (int.TryParse(input, out int number))
            {
                number = Math.Abs(number);

                for (int temp = number; temp > 0; temp /= 10)
                {
                    int digit = temp % 10;
                    sum += digit;
                }

                Console.WriteLine("The sum of the digits is: " + sum);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }

}
