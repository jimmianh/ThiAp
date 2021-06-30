using System;

namespace Human
{
    public class Student: Person
    {
      
        public override void ShowMyName()
        {
            Console.WriteLine($"Tôi là {FirstName} {LastName}, tôi là sinh viên.");
        }

        public Student(string FirstName, string LastName) :base(FirstName,LastName)
        {
        }
    }
}