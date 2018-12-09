using System;
using System.Collections.Generic;

namespace TASK4.WordFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text");
            string text = Console.ReadLine();
            
            var WordFrequencyCount = new Dictionary<string,int>();

         
            foreach (var word in text.Split(" "))
            {
                if (word.Trim() == "")
                    continue;

                var actualWord = word.Trim(',', '.', ' ', ';', ':', '-', '?', '!', ')', '(');
                if (!WordFrequencyCount.ContainsKey(actualWord))
                {
                    WordFrequencyCount.Add(actualWord,1);
                }
                else
                {
                    WordFrequencyCount[actualWord]++;
                }
            }
            
            Console.WriteLine("Here's word frequency of every word:\n");

            foreach (var word in WordFrequencyCount)
            {
                Console.WriteLine("\"{0}\" occured {1} times", word.Key, word.Value);
            }
        }
    }
}