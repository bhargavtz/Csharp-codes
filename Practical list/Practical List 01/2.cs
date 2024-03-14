using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//vhp
class Converter
{
    private int Data, Days, weeks, years;
   
    private void gateData()
    {
        Console.Write("enter tha day:-");
        Data = Convert.ToInt32(Console.ReadLine());
    }
    public void ConvertDays()
    {
        gateData();
        int years = Data / 365;
        int Days = Data % 365;
        int weeks = Days / 7;
        Days = Days % 7;
     Console.WriteLine("years" + years + "\n Days" + Days + "\n weeks" + weeks);
    }

}
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter daey =new Converter();
            daey.ConvertDays();
            
            Console.Read();
        }
    }
}
-----

/* Q2.Create an application to convert a given number of days in terms
of Years, Weeks & Days. */

using System;
namespace Conversion
{
    class Calculate {
        static void calculate(int days)
        {
            int year = days / 365;
            int week = (days % 365) / 7;
            int day = (days % 365) % 7;
            
            Console.Write("years :" + year + "\nweek  :" + week + "\ndays  :" + day);
            
        }
        static void Main() {
        Console.WriteLine("Enter Days:");
        int days = Convert.ToInt32(Console.ReadLine());
        calculate(days);
      }
    }
}
