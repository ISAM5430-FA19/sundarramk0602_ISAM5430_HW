using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HW04_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int vowel = 0;
            int consonant = 0;
            int syllable = 0;

            //Question-6

            while (true)
            {
                var KeyInfo = ReadKey();
                char letter = char.ToUpperInvariant(KeyInfo.KeyChar);
                char character = letter;
                if (!char.IsLetter(letter))
                {
                    break;
                }
                count++;

                // Question-7

                if (letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
                {
                    vowel++;
                }
                else
                {
                    consonant++;
                }

                // Question-8

                if ((character == 'A' || character == 'E' || character == 'I' || character == 'O' || character == 'U') && (character != 'A' ||
                    character != 'E' || character != 'I' || character != 'O'))
                {
                    syllable++;
                }

                Console.WriteLine("Number of letters entered by user is"+ count);
                Console.WriteLine("Number of vowels and consonants entered by user is" + vowel , consonant);
                Console.WriteLine("Number of syllables are:" + syllable);
                //WriteLine("count number of letters");

                ReadLine();
            }
        }
    }
}