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
            int[] luckyNumbers = {4,8,16,23,42 };
            string[] friends = new string[5];
            friends[0] = "Mphatso";
            friends[1] = "Chicco";

            luckyNumbers[1] = 900;
            Console.WriteLine(luckyNumbers[1]);

            Console.ReadLine();
        }
    }
}