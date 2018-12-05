using System;

namespace TASK3.MyString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            var str1 = Console.ReadLine();
            Console.Write("Enter another string: ");
            var str2 = Console.ReadLine();
            
            var myStr1 = new MyString(str1);
            var myStr2 = new MyString(str2);

            if (myStr2 != myStr1)
            {
                Console.WriteLine("Strings ARE NOT equal");
            }
            else
            {
                Console.WriteLine("Strings ARE equal");
            }

            var temp = myStr1 + myStr2;

            Console.WriteLine("Result of Concatination : {0}", (myStr1 + myStr2).ToString());

            Console.Write("Enter the character to find : ");
            char charToFind;
            try
            {
                charToFind = Console.ReadLine().Trim()[0];
            }
            catch
            {
                Console.WriteLine("Your char is weird. Try again next time.");
                throw;
            }

            int indexOfChar = str1.IndexOf(charToFind);
            if (indexOfChar == -1)
            {
                Console.WriteLine("There's no such char in this string: {0}", str1);
            }
            else
            {
                Console.WriteLine("Character found on position {0},\n check it yourself though: {1}", indexOfChar+1, str1);
            }
            
            
        }
    }
}