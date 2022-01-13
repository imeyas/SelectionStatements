using System;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Math.Abs(10);
            
            
            //If-Else Statements part of exercise

            Console.WriteLine("What is my favorite number?");
            var theNum = 17;
            //var r = new Random();
            //var favNumber = r.Next(1,10);
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < theNum)
            {
                Console.WriteLine("too low");
            }
            else if (userInput > theNum)
            {
                Console.WriteLine("too high");
            }
            else if (userInput == theNum)
            {
                Console.WriteLine("You nailed !");
            }

        }
    }
}