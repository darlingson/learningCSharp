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
            Console.WriteLine(5+8);// csharp will add the numbers and print the result
            Console.WriteLine(5 + 9 * 2);// normal order of operation
            Console.WriteLine((5 + 9) * 2);// specified order of operation

            Console.ReadLine();
        }
    }
}