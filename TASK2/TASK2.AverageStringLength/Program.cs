using System;

namespace TASK2.AverageStringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string: ");

            string s = Console.ReadLine();

            bool newWord = true;
            int sum = 0;
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    if (newWord)
                    {
                        count ++;
                        newWord = false;
                    }

                    sum++;
                }
                else
                {
                    newWord = true;
                }
            }

            Console.WriteLine("Average length of the strings: " + (double) sum / count);
        }
    }
}