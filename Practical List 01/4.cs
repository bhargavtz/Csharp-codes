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
        
            
                int sum = 0;

               
                for (int i = 1; i <= 50; i++)
                {
                    sum += i;
                }

                Console.WriteLine("Sum of the first 50 natural numbers: "+sum);
            Console.Read();
        }
    
    }
}

-----
 /* Q4.Create an application to find the sum of first 50 natural numbers
using For Loop. */

using System;
namespace Conversion
{
    class Calculate {
       
        
        static void Main() {
        int z = 0;
        for(int i = 0; i <= 50; i++)
        {
            z += i;
        }
        
        Console.WriteLine(z);
      }
    }
}