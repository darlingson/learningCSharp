using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace learningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# if statements part 2
            //Console.WriteLine(GetMax(2,5));

            //Console.ReadLine();
            //calculator();
            //switchStatement();
            //whileLoop();
            //dowhileloop();
            //guessingGame();
            //forLoop();
            exponents();
        }
        static int GetMax(int num1, int num2)
        {
            int result;

            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }

            return result;
        }
        static void calculator()
        {
            Console.Write("Enter a number");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an operator");
            string op = Console.ReadLine();

            Console.Write("Enter a number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("hi");

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }
        }

        static void switchStatement()
        {
            Console.Write("Enter a day number :");
            int dayNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetDay(dayNum));
        }
        static string GetDay(int dayNum)
        {
            string dayName;
            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednsday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }

            return dayName;
        }
        static void whileLoop()
        {
            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }
        }
        static void dowhileloop()
        {
            int index = 6;
            do
            {
                Console.WriteLine(index);
                index++;
            }while (index <= 5);
        }
        static void guessingGame()
        {
            string secretWord = "Darlingson";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter Guess");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            if (outOfGuesses)
            {
                Console.WriteLine("you lose");
            }
            else {
                Console.WriteLine("You Win");
            }
        }
        static void forLoop()
        {
            Console.WriteLine("while loop");
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("for loop");
            for (int index =1; index <= 5; index++)
            {
                Console.WriteLine(index);
            }


            int[] luckyNumbers = {4,8,15,16,23,42 };
            for(int index =0; index < luckyNumbers.Length; index++)
            {
                Console.WriteLine(luckyNumbers[index]);
            }
        }
        static void exponents()
        {
            Console.WriteLine(GetPow(2, 3));
            Console.WriteLine(GetPow(3, 2));
        }
        static int GetPow(int baseNum, int powNum)
        {
            int result =1;
            for (int index = 0; index < powNum; index++)
            {
                result = result * baseNum;
            }
            return result;
        }
    }
}
