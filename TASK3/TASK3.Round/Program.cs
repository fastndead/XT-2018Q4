using System;
using System.ComponentModel.Design.Serialization;

namespace TASK3.Round
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius = 2, 
                x = 1 , 
                y = 2;
            
            Round round;
            try
            {
                round = new Round(radius,x,y);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            round.Show();
        }
    }
}