using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Write a program that prints all the odd numbers from 1 to 20 using a for loop. 
            */
             int num1 = 20;
            for (int i = 1; i < num1; i += 2)
            { Console.WriteLine(i); }
        }
    }
}
