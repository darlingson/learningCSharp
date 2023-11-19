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
            //C# return statements
            Console.Write("The number to cube:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Cube(num));


            Console.ReadLine();
        }
        static int Cube(int num)
        {
            int cube = num * num * num;
            return cube;
        }
    }
}