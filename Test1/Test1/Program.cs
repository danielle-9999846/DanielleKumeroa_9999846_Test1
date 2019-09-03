using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------This program can give the result of base^exponent------------------------");
            Console.Write("Enter the value of the base:  ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the value of the exponent: ");
            int num2 = int.Parse(Console.ReadLine());

            double result;
            result = Math.Pow(num1,num2);

            Console.WriteLine("{0} ^ {1} = {2}", num1, num2, result);
            
                


        }
    }
}
