using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//vhp
class Bank
{
    private int amount, balance;
    private string name, type;

    public Bank()
    {
        balance = 501;
    }

    public void GetData()
    {
        Console.Write("Enter amount: ");
        amount = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter name: ");
        name = Console.ReadLine();
        Console.Write("Enter type: ");
        type = Console.ReadLine();
      
    }

    public void Deposit(int depositAmount)
    {
        balance += depositAmount;
        Console.WriteLine("Your balance: " + balance);
    }

    public void Withdraw(int withdrawalAmount)
    {
        if (balance < 500 || balance <= withdrawalAmount)
        {
            Console.WriteLine("Not enough balance available.");
        }
        else
        {
            balance -= withdrawalAmount;
            Console.WriteLine("Your balance: " + balance);
        }
    }

    public void Display()
    {
        Console.WriteLine("------Your Details------");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Type: " + type);
        Console.WriteLine("Balance: " + balance);
    }
}
namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            int amount;
            int choice;
            Bank account = new Bank();

            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Enter Account Details");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Display Account Details");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        account.GetData();
                        break;
                    case 2:
                        Console.Write("Enter deposit amount: ");
                        amount = Convert.ToInt32(Console.ReadLine());
                        account.Deposit(amount);
                        break;
                    case 3:
                        Console.Write("Enter withdrawal amount: ");
                        amount = Convert.ToInt32(Console.ReadLine());
                        account.Withdraw(amount);
                        break;
                    case 4:
                        account.Display();
                        break;
                    case 5:
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            } while (choice != 5);
        }
    }
}
  
----
using System;

class Program {

  static void Main(string[] args) {
    
    double balance = 1000;

    while(true) {

      Console.WriteLine("1. Check Balance");
      Console.WriteLine("2. Withdraw Cash");
      Console.WriteLine("3. Deposit Cash");
      Console.WriteLine("4. Exit");

      Console.Write("Choose option: ");
      int opt = int.Parse(Console.ReadLine());

      if(opt == 1) {
        Console.WriteLine("Balance: " + balance);
      }
      else if(opt == 2) {
        Console.Write("Enter amount: ");
        double amt = double.Parse(Console.ReadLine()); 
        balance -= amt;
        Console.WriteLine("Withdrawal successful");
      }
      else if(opt == 3) {  
        Console.Write("Enter amount: ");
        double amt = double.Parse(Console.ReadLine());
        balance += amt;
        Console.WriteLine("Deposit successful");  
      }
      else {
        Environment.Exit(0);
      }

    }

  }

}