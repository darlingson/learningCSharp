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
            //C# if statements
            bool isMale = false;
            bool isTall = false;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a Tall Male");
            }else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are a tall female");
            }
            else
            {
                Console.WriteLine("You are a short Female");
            }

            Console.ReadLine();
        }
    }
}