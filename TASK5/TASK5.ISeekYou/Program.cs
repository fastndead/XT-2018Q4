using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace TASK5.ISeekYou
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new int[] {1, 2, 3, 4, -5, 6, -7, 8, -9};
            Show(a.Searcher((x) => x >= 0));
            Show(a.Searcher(delegate(int x) { return x > 0; }));
            Show(a.Searcher((x) => x >= 0));
            Show(a.Searcher((x) => x >= 0));
            
        }

        static public void Show(IEnumerable<int> arr)
        {
            foreach (var n in arr)
            {
                Console.Write("{0} ",n);
            }

            Console.WriteLine();
        }
    }
}