using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHi();

            SayHiAge("John", 55);

            SayHiUser("Evans");

            Console.ReadLine();

        }
        static void SayHi()
        {
            Console.WriteLine("Hi");
        }

        static void SayHiUser(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        static void SayHiAge(string name, int age)
        {
            Console.WriteLine("Hello " + name + "you are " + age);

            Console.ReadLine();
        }
    }
}
