/* Q5.Create an application to take inputs from the user and perform
addition, subtraction, multiplication and division of two numbers */
using switch...case and function.

using System;

namespace ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            char operation;

           
            Console.Write("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the operation (+, -, *, /): ");
            operation = char.Parse(Console.ReadLine());

         
            switch (operation)
            {
                case '+':
                    Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
                    break;
                case '/':
                    // division by zero
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                    }
                    else
                    {
                        Console.WriteLine(num1 + " / " + num2 + " = " + (num1 + num2) );
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }
        }

    }
}

===
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//vhp
class Calculator
{
    public static void PerformOperations(double num1, double num2, char operation)
    {
        double result ;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Invalid operation.");
                return;
        }

        Console.WriteLine("Result: "+result);
    }
}
namespace ConsoleApp2
{
    class Program
{
    static void Main()
    {
        
        Console.Write("Enter the first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        
        Console.Write("Enter the operation (+, -, *, /): ");
        char operation = Convert.ToChar(Console.ReadLine());

     
        Calculator.PerformOperations(number1, number2, operation);
            Console.Read();
        }
}

}