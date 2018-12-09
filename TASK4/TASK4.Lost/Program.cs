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
            for (int i = 0; i < n; i++)
            {
                people.Add("SampleName" + (i+1));
            }
            while (people.Count != 1)
            {
                var i = 1;
                while (i < people.Count)
                {
                    people.RemoveAt(i);
                    i++;
                }
            }
            Console.WriteLine("Only person remained in the array: {0}", people[0]);
        }
    }
}