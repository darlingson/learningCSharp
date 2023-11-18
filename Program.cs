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
            string name = "Darlingson" + " is cool"; //string concatenation
            Console.WriteLine("Darlingson");
            Console.WriteLine("Darlingson\nMakuwila"); //printing to new line
            Console.WriteLine("Darlingson\"Makuwila"); //deleniting a "

            Console.WriteLine(name);// printing a string from variable
            Console.WriteLine(name.Length); //length of string

            //String methods
            Console.WriteLine(name.ToUpper()); //uppercase
            Console.WriteLine(name.ToLower()); //lowercase
            Console.WriteLine(name.Contains("is cool")); //checking for substring
            Console.WriteLine(name[0]); // finding the character at index 0
            Console.WriteLine(name.IndexOf("is")); //find the position of substring
            Console.WriteLine(name.Substring(11));

            Console.ReadLine();
        }
    }
}