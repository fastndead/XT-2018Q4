using System;
using System.Collections.Generic;

namespace TASK4.DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new DynamicArray<int>(new int[]{1,2,3,4,5,6,7});
            a.AddRange(new int[]{ 8,9,10});
            a.Add(10000);
            a.Insert(0, 8);
            a.Remove(0);
            
            foreach (var item in a)
            {
                Console.Write("{0}, ", item);
            }
            Console.WriteLine("\nCapacity: {0}", a.Capacity);
            Console.WriteLine("Length: {0}", a.Length);

        }
    }
}