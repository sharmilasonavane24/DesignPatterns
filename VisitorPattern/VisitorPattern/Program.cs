using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Apples;
using VisitorPattern.Bananas;
using VisitorPattern.Strawberries;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var snacker = new Snacker();

            var banana = new Banana();

            var apple = new Apple();
            
            var strawberry = new Strawberry();

            Console.WriteLine("Snacking on an apple...");

            apple.Accept(snacker);
            
            Console.WriteLine("Snacking on a banana...");

            banana.Accept(snacker);

            Console.WriteLine("Snacking on a strawberry...");

            strawberry.Accept(snacker);

            Console.ReadLine();
        }
    }
}
