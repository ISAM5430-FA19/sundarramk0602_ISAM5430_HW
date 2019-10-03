using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HW04_B._2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("At least one vowel");
            for (char i='A';i<='H';i++)
            {
                for(char j='A';j<='H'; j++)
                {
                    if(i=='A' || i=='E' || j=='A' || j=='E')
                    {
                        WriteLine(i + "," + j);
                    }
                }
            }

            WriteLine("One vowel and one consonant");
            for (char i = 'A'; i <= 'H'; i++)
            {
                bool vowela = i == 'A' || i == 'E';

                for (char j = 'A'; j <= 'H'; j++)
                {
                    bool vowelb = j == 'A' || j == 'E';

                    int vowels2 = (vowela ? 1 : 0) + (vowelb ? 1 : 0);
                    if(vowels2==1)
                    {
                        WriteLine($"{i},{j}");
                    }
                    }
                }

            WriteLine("begin with consonant and end with vowel ");
            for (char i = 'A'; i <= 'H'; i++)
            {
                bool vowela = i != 'A' && i != 'E';

                for (char j = 'A'; j <= 'H'; j++)
                {
                    bool vowelb = j == 'A' || j == 'E';

                    int vowels2 = (vowela ? 1 : 0) + (vowelb ? 1 : 0);
                    if (vowels2 == 2)
                    {
                        WriteLine($"{i},{j}");
                    }
                }
            }

            ReadLine();
        }
    }
}
