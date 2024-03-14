/* Q3.Create an application to take input from user and check whether
the year is a leap year or not using function. */

using System;
namespace Conversion
{
    class Calculate {
        static void check(int year)
        {
            if( (year % 4 == 0) && (year != 100 ) || (year % 400 == 0))
            {
                Console.Write("it's a leap year");
            }
            else
            {
                Console.Write("it's not a leap year");
            }
        }
        
        static void Main() {
        Console.WriteLine("Enter Year:");
        int Year = Convert.ToInt32(Console.ReadLine());
        check(Year);
      }
    }
}
---
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//vhp


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int Year = Convert.ToInt32(Console.ReadLine());
            if ((Year % 4 == 0 && Year % 100 != 0) )
                    {
                Console.WriteLine("is a leap year.");
            }
            else
            {
                Console.WriteLine("is not leap year.");
            }

            Console.Read();
        }
    }
}