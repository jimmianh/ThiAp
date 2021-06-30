using System;

namespace Human
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var student = new Student("anh", "vu");
            var teacher = new Teacher("ngoc", "anh");
            student.ShowMyName();
            teacher.ShowMyName();
        }
    }
}