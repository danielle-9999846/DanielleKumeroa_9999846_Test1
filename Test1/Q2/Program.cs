using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------This program will give the sum total of 5 items------------------");


            decimal start = 1;
            decimal finish = 5;
            Console.WriteLine("Please enter the price of item  : ");


            for (decimal i = start; i <= finish; i++)
            { Console.WriteLine($"{i}"); }
            Console.ReadLine();
        }

    }
    
}
