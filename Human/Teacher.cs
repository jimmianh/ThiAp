using System;

namespace Human
{
    public class Teacher: Person
    {
        public Teacher(string FirstName, string LastName) : base(FirstName, LastName)
        {
        }

        public override void ShowMyName()
        {
            Console.WriteLine($"Tôi là {FirstName} {LastName}, tôi là giáo viên.");
        }
    }
}