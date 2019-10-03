using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HW04_B._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
             WriteLine("At least one vowel with three letters");
             for (char i = 'A'; i <= 'H'; i++)
             {
                 for (char j = 'A'; j <= 'H'; j++)
                 {
                     for (char k = 'A'; k <= 'H'; k++)
                     {
                         if (i == 'A' || i == 'E' || j == 'A' || j == 'E' || k == 'A' || k == 'E')
                             WriteLine($"{i},{j},{k}");
                 }

                 }
             } 

             WriteLine("middle letters to be a vowel");
             for (char i = 'A'; i <= 'H'; i++)
             {
                 for (char j = 'A'; j <= 'H'; j++)
                 {
                     for (char k = 'A'; k <= 'H'; k++)
                     {
                         if (i != 'A' && i != 'E' && j == 'A' || j == 'E' && k != 'A' && k != 'E')
                             WriteLine($"{i},{j},{k}");
                     }

                 }
             } 

            WriteLine("One consonant and one vowel with three letters");
            for (char i = 'A'; i <= 'H'; i++)
            {
                bool vowela = i == 'A' || i == 'E';
                for (char j = 'A'; j <= 'H'; j++)
                {
                    bool vowelb = j == 'A' || j == 'E';
                    for (char k = 'A'; k <= 'H'; k++)
                    {
                        bool vowelc = k == 'A' || k == 'E';
                        int vowels = (vowela ? 1 : 0) + (vowelb ? 1 : 0) + (vowelc ? 1 : 0);
                        if (vowels == 1 || vowels == 2)
                        {
                            WriteLine($"{i},{j},{k}");
                        }
                    }
                }
            }

            WriteLine("middle letter vowel and unique character");
            for (char i = 'A'; i <= 'H'; i++)
            {
                for (char j = 'A'; j <= 'H'; j++)
                {
                    for (char k = 'A'; k <= 'H'; k++)
                    {
                        if (i != 'A' && i != 'E')
                        {
                            if (j == 'A' || j == 'E')
                            {
                                if (k != 'A' && k != 'E')
                                {
                                    if(i!=k)
                                    WriteLine($"{i},{j},{k}");
                                }
                            }
    }
                    }
                }
            }
            
          ReadLine();
        }
    }
}
