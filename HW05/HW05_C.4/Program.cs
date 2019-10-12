using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW05_C._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the park name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the park location");
            string location = Console.ReadLine();
            Console.WriteLine("Enter the park type");
            string type = Console.ReadLine();
            Console.WriteLine("Enter the park fees");
            int fees = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the park employees");
            int employee = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the park visitors");
            int visitor = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the park budget");
            decimal budget = decimal.Parse(Console.ReadLine());
            Park park = new Park(name, location, type, fees, employee, visitor, budget);
            Console.ReadLine();
        }
    }
}
