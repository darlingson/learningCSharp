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
            int num = Convert.ToInt32("43"); //convert string to int
            Console.WriteLine(num);


            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter anotherf number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + num2);


            Console.ReadLine();
        }
    }
}