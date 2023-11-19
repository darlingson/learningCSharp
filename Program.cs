using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# methods
            Console.Write("What is your name?:");
            string name = Console.ReadLine();
            SayHi(name);
            Console.ReadLine();
        }
        static void SayHi(string name)
        {
            Console.WriteLine("Hello User "+ name);
        }
    }
}