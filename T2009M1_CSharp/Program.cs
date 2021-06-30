using System;

namespace T2009M1_CSharp
{
    internal class Program
    {
        delegate void MyDelegate(string name);

        static void HelloWorld(string name)
        {
            Console.WriteLine("helloworld");
        }

        static void Goodbye(string name)
        {
            Console.WriteLine("goodbye" + name);
        }
        public static void Main(string[] args)
        {
            
            MyDelegate myDelegate = HelloWorld;
            myDelegate("anh");
            
        }
    }
}