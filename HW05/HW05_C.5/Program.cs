using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HW05_C._5
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Date date = new Date(month, day,year);
            WriteLine("Enter the month");
            int month = int.Parse(ReadLine());
            WriteLine("Enter the day");
            int day = int.Parse(ReadLine());
            WriteLine("Enter the year");
            int year = int.Parse(ReadLine());
            Date date = new Date(month, day, year);

            WriteLine(date.DisplayDate());

            ReadLine();
        }
    }
}
