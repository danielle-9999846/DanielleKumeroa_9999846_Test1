using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------Can you solve the following algebraic question?----------" );
            Console.WriteLine("--------------------------2(x-3)+x=12-------------");

            Console.Write("Enter your guess at the value of x: ");
            int guess = int.Parse(Console.ReadLine());
            int x = 6;//2(x-3)+x=12 -> 2x-6+x=12 -> 3x-6=12 -> 3x=18 -> 3x/3=18/3 x=6 
            if (guess == 6 )
            { Console.WriteLine("Your guess is correct");
                Console.ReadLine();

            }
            else
            { Console.WriteLine("Your guess is incorrect");
                Console.ReadLine();

            }
        
        }
    }
}
