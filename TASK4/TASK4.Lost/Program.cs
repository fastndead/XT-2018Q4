using System;
using System.Collections.Generic;
using System.Linq;

namespace TASK4.Lost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int n;
            try
            {
                n = int.Parse(Console.ReadLine());
                if (n<1)
                {
                    throw new Exception("N must be greater than 0");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            var people = new List<string>();
            for (int k = 0; k < n; k++)
            {
                people.Add("SampleName" + (k+1));
            }


            var i = 1;  
            while (people.Count != 1)
            {
                people.RemoveAt(i);
                
                if (i == people.Count)
                {
                    i = 1;
                    continue;
                }
                if (i == people.Count - 1)
                {
                    i = 0;
                    continue;
                }
                i++;
            }
            
            Console.WriteLine("Only person remained in the array: {0}", people[0]);
        }
    }
}