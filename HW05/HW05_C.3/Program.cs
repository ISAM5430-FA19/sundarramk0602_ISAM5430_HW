using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW05_C._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dollar");
            int dollar = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the cents");
            int cent = int.Parse(Console.ReadLine());
            Money money = new Money(dollar, cent);
            Console.WriteLine("Amount:" + money._dollars + money._cents);
            Console.WriteLine("Enter the increment dollar");
            int D = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the increment cent");
            int C = int.Parse(Console.ReadLine());
            money.IncrementMoney(D, C);
            Console.WriteLine("Increment money:" + money._dollars + money._cents);
            Console.WriteLine("Enter the decrement dollar");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the decrement cent");
            int c = int.Parse(Console.ReadLine());
            money.DecrementMoney(d, c);
            Console.WriteLine("Decrement money:" + money._dollars + money._cents);
            Console.WriteLine(money.ToString());
            Console.ReadLine();
        }
    }
}
