using System;
using System.Reflection.Metadata;
using TASK3.User;

namespace TASK3.Employee
{
    public class Employee : User.User
    {
        private string Position { get; }
        private int Experience { get; }
        
        public Employee(string firstName, string secondName, string lastName, DateTime dateOfBirth, string position, int experience) 
            : base(firstName, secondName, lastName, dateOfBirth)
        {
            if (experience < 0 || experience > this.Age)
            {
                throw new Exception("Experience is not in correct format");
            }
            Position = position;
            Experience = experience;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Postiton: {0}", Position);
            Console.WriteLine("Experience: {0}", Experience);
        }



    }
}