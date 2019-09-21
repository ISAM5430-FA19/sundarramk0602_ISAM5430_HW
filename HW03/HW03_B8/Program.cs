using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03_B8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first integer:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer:");
            int b = int.Parse(Console.ReadLine());
            int rev = 0;
            int sum = a + b;
            while (sum>0)
            {
                rev = (rev * 10) + (sum % 10);
                sum = sum / 10;
            }
            Console.WriteLine($"reverse: {rev}");
            Console.ReadLine();
        }
    }
}
