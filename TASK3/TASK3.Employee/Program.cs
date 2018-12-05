using System;

namespace TASK3.Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Ivan",
                secondName = "Ivanovich",
                lastName = "Ivanov",
                position = "Janitor";
            int experience = 20;//dude was working since birth
            DateTime dateOfBirth = new DateTime(1998,1,1);
            Employee user;
            try
            {
                user = new Employee(firstName, secondName, lastName, dateOfBirth, position,experience);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            } 
            user.Show();
        }
    }
}