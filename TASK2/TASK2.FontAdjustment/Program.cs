using System;
using System.Collections.Specialized;
using System.Security.Cryptography;

namespace TASK2.FontAdjustment
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Font propeties: ");
                Console.Write("Options selected: ");
                Font.GetTypes();
                Console.WriteLine("Enter:\n" +
                                  "1:\tBOLD\n" +
                                  "2:\tITALIC\n" +
                                  "3:\tUNDERLINE\n" +
                                  "ESC:\tEXIT");
                
                var action = Console.ReadKey();
                if (action.Key != ConsoleKey.Escape)
                {
                    Console.WriteLine();
                    switch (action.Key)
                    {
                        case ConsoleKey.D1:
                                Font.SetType(1);
                                break;
                        case ConsoleKey.D2:
                                Font.SetType(2);
                                break;
                        case ConsoleKey.D3:
                                Font.SetType(3);
                                break;
                        case ConsoleKey.D0:
                                Font.SetType(0);
                                break;
                    }
                }
                else
                {
                    break;
                }
            }


        }

    }
}