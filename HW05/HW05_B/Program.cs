using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HW05_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Jane Green", 50.00m);
            Account account2 = new Account("John Blue", -7.53m);
            Console.WriteLine($"{account1.Name} 's balance: {account1.Balance}");
            Console.WriteLine($"{account2.Name} 's balance: {account2.Balance}");

            Console.Write("\n Enter withdrawal amount for account1: ");
            decimal withdrawalAmount = decimal.Parse(ReadLine());
             Console.WriteLine($"withdraw {withdrawalAmount:C} from account1 balance\n");
            account1.Withdrawal(withdrawalAmount);
             WriteLine($"{account1.Name} 's balance: {account1.Balance:C}");
             WriteLine($"{account2.Name} 's balance: {account2.Balance:C}");

            Console.Write("\n Enter withdrawal amount for account2: ");
            withdrawalAmount = decimal.Parse(ReadLine());
            Console.WriteLine($"withdraw {withdrawalAmount:C} from account2 balance\n");
            account2.Withdrawal(withdrawalAmount);
            WriteLine($"{account1.Name} 's balance: {account1.Balance}");
            WriteLine($"{account2.Name} 's balance: {account2.Balance}");

            ReadLine();
        }
    }
}
