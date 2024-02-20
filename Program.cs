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
            //exponents();
            //twoDArray();
            //exceptionHandling();
            //objectsandclasses();
            staticmethodsandclasses();


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
        static void twoDArray()
        {
            int[,] numberGrid =
            {
                {1,2 },
                {3,4 },
                {5,6},
            };
            Console.WriteLine(numberGrid[0, 0]);
            Console.WriteLine(numberGrid[1, 1]);

        }
        static void exceptionHandling()
        {
            try
            {
                Console.WriteLine("Enter a number");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a number");
                int number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(number1 / number2);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error : Invalid input");
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("");
            }
        }
        static void objectsandclasses()
        {
            Book book1 = new Book("Harry, Potter", "JK Rowling",400);
            //book1.title = "Harry Potter";
            //book1.author = "JK Rowling";
            //book1.pages = 400;

            Book book2 = new Book("Lord of the Rings", "Tolkein",700);
            //book2.title = "Lord of the Rings";
            //book2.author = "Tolkein";
            //book2.pages = 700;

            Console.WriteLine(book1.title);
            Console.WriteLine(book2.pages);


            Student student1 = new Student("Jim","Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());


            Movie movie1 = new Movie("Avengers", "Joss Whedon", "PG-13");
            Movie movie2 = new Movie("Shrek", "Adam Adamson", "Dog");

            Console.WriteLine(movie2.Rating);

            Song holiday = new Song("Holiday","Green Day",200);
            Song Kashmir = new Song("Kashmir", "Led Zeppelin", 150);

            Console.WriteLine(holiday.title);
            Console.WriteLine(holiday.artist);

            Console.WriteLine(Song.SongCount);
            Console.WriteLine(holiday.getSongCount());
        }
        public static void staticmethodsandclasses()
        {
            Console.WriteLine(Math.Sqrt(144));
            UsefulTools.SayHi("Darlingson");
        }
    }
}
