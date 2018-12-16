using System;

namespace TASK5.NumberArraySum
{
    static class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[]{1, 26, -12, 55, 34567, -234, 0};
            Console.WriteLine("initial array: ");
            foreach (var number in array)
            {
                Console.Write("{0} + ", number);
            }

            Console.WriteLine(" = {0}", array.GetSum());
        }
        
        private static T GetSum<T>(this Array array, Func<T, T, T> sumFunc)
        {
            var temp = Activator.CreateInstance<T>();
            foreach (var item in array)
            {
                temp = sumFunc(temp, (T)item);
            }
            return temp;
        }
        
        public static int GetSum(this int[] array) => array.GetSum<int>((x, y) => x + y);
        
        public static double GetSum(this double[] array) => array.GetSum<double>((x, y) => x + y);
        
        public static decimal GetSum(this decimal[] array) => array.GetSum<decimal>((x, y) => x + y);

    }
}