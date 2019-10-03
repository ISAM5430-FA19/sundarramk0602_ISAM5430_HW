using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HW04_B._2._5
{
    class Program
    {
        static void Main(string[] args)
        {
             Write("\n At least one vowel with two letters & three letters");
             for (char i = 'A'; i <= 'H'; i++)
             {
                 for (char j = 'A'; j <= 'H'; j++)
                 {
                     if (i == 'A' || i == 'E' || j == 'A' || j == 'E')
                     {
                         Write(i + "," + j);
                     }
                     for (char k = 'A'; k <= 'H'; k++)
                     {
                         if (k == 'A' || k == 'E')
                         {
                             Write(i + "," + j + "," + k);
                         }
                     }
                     }
                 } 

            Write("\n Begin with consonant and end with vowel");

             for (char i = 'A'; i <= 'H'; i++)
             {
                 for (char j = 'A'; j <= 'H'; j++)
                 {
                     if (i != 'A' && i != 'E')
                     {
                         if (j == 'A' || j == 'E')
                         {
                             WriteLine(i + "," + j);
                         }
                         for (char k = 'A'; k <= 'H'; k++)
                         {
                             if (k == 'A' || k == 'E')
                             {
                                 WriteLine(i + "," + j + "," + k);
                             }
                         }
                     }
                 }
              } 

             Write("\n Middle letter vowel and unique");

             for (char i = 'A'; i <= 'H'; i++)
             {
                 for (char j = 'A'; j <= 'H'; j++)
                 {
                     if (i != 'A' && i != 'E')
                     {
                         if (j == 'A' || j == 'E')
                         {
                             if (i != j)
                             {
                                 WriteLine(i+ "" +j);
                         }
                         for (char k = 'A'; k <= 'H'; k++)
                         {
                             if (k != 'A' || k != 'E')
                             {
                                     WriteLine(i + "" + j + "" + k);
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
