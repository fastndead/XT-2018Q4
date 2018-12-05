using System;

namespace TASK3.Ring
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius = 2,
                innerRadius = 1,
                x = 1,
                y = 2;
            
            Ring round;
            try
            {
                round = new Ring(radius,x,y, innerRadius);
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