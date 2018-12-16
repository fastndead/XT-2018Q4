using System;
using System.Text.RegularExpressions;

namespace TASK5.ToIntOrNotToInt
{
    static class Program
    {
        
        private static bool IsInt(this string str)
        {
            str = str.Trim();

            var EIndex = -1;
            var dotIndex = -1;
            for (var index = 0; index < str.Length; index++)
            {
                var character = str[index];
                if (character == '+' || character == '-')
                {
                    if (index == 0 || index == EIndex + 1)
                    {
                        continue;
                    }

                    return false;
                }

                if ((character == 'E' || character == 'e') )
                {
                    if (EIndex == -1)
                    {
                        EIndex = index;
                        dotIndex = -1;
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }

                if (character == '.' || character == ',')
                {
                    if (dotIndex == -1)
                    {
                        dotIndex = index;
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }

                if (char.IsDigit(character))
                {
                    continue;
                }

                if (!char.IsDigit(character))
                {
                    return false;
                }
            }

            return true;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            var str = Console.ReadLine();

            if (str.IsInt())
            {
                Console.WriteLine("It is a number!");
            }
            else
            {
                Console.WriteLine("It ISN't a number!");
            }
        }
    }
}