using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//vhp

class Converter
{
    private double temperature;

    public void CelsiusToFahrenheit()
    {
        temperature = (temperature * 9 / 5) + 32;
    }

    public void GetData()
    {
        
        temperature = Convert.ToDouble(Console.ReadLine());
    }

    public void DisplayResult()
    {
        CelsiusToFahrenheit();
        Console.WriteLine("Temperature in Fahrenheit:"+ temperature);
        Console.Read();
    }
}
class Program
{
    static void Main()
    {
        
        Converter converter = new Converter();
        Console.WriteLine("enter Temperature :");
        converter.GetData();
        converter.DisplayResult();
        
    }
}
---
/* Q1.Create a console application in C# to perform Celsius to
Fahrenheit Conversion. */

using System;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.Write("Enter temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

          
            double fahrenheit = (celsius * 9 / 5) + 32;

     
            //Console.WriteLine("{0} Celsius is equal to {1} Fahrenheit", celsius, fahrenheit);
            Console.WriteLine(celsius + " Celsius is equal to " +  fahrenheit + " Fahrenheit" );
        }
    }
}
