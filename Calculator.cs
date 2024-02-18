using System;

namespace learningCSharp
{
    public class Calculator
    {
        static void CalculatorMain()
        {
            Console.Write("Enter a number");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an operator");
            string op = Console.ReadLine();

            Console.Write("Enter a number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("hi");

            if(op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if(op == "-")
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

    }
}