
// Create an application to take two numbers from user and display the sum of them.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;

        Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, sum);
        // sum is answer - num1 is First values - num2 is sec values 
    }
}
