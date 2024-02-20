using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningCSharp
{
    class ItalianChef : Chef
    {
        public void makePawn()
        {
            Console.WriteLine("The chef makes pawn");
        }
        public override void MakeSpecialDish() 
        {
            Console.WriteLine("Chef makes Pasta");
        }
    }
}
