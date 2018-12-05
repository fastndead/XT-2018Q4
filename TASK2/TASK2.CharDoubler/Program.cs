using System;
using System.Linq;

namespace TASK2.CharDoubler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string:");
            var s1 = Console.ReadLine();
            Console.WriteLine("Enter second string:");
            var s2 = Console.ReadLine();
            
            char[] mas = s2.ToCharArray();

            for (int i = 0; i < s1.Length; i++)
                {
                    if (mas.Contains(s1[i]))
                    {
                        s1 = s1.Insert(i, s1[i].ToString());
                        i++;
                    }
                }

            Console.WriteLine("Result: \n{0}", s1);
        }
    }
}