using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // In the fibonacci sequence, where f(n) = f(n - 1) + f(n - 2)
            // begin by the setting first value a to zero, the second value b to 1. Initialize the n and the result without giving them any values

           int a = 0;
           int b = 1;
           int n, result;

            // ask the user to enter the value and store it in n
           Console.WriteLine("Enter a number: ");
           n = Convert.ToInt32(Console.ReadLine());

            // We need to loop through, from i to n i.e the value you just entered. i should not exceed n
           for (int i = 0; i <= n; i++)
           {
                // Print the result of the number entered, where result is the sum of the first 2 numbers and a is set to be
                // The process is repeated till n is reached
            Console.WriteLine(a);
            result = a  + b;
            a = b;
            b = result;
           }
           
        }
    }
}
