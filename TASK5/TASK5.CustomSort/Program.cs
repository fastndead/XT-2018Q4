﻿using System;

namespace TASK5.CustomSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1, 26, -12, 55, 34567, -234, 0};
            
            Console.WriteLine("Before sorting: ");
            foreach (var number in array)
            {
                Console.Write("{0} ", number);
            }
            
            var func = new Func<int, int, bool>(Compare);
            Sort(ref array, func);
            
            Console.WriteLine("\nAfter sorting:");
            foreach (var number in array)
            {
                Console.Write("{0} ", number);
            }

        }
        
        
        public static bool Compare(int num1, int num2)
        {
            return num1 > num2;
        }
        
        public static void Sort<T>(ref T[] array, Func<T, T, bool> comparer)
        {
            for (int i = 1; i < array.Length; i++)
            {
                T cur = array[i];
                int j = i;
                while (j > 0 && comparer.Invoke(array[j - 1], cur))
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = cur;
            }
        }

    }
}