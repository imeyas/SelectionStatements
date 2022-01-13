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
            var r = new Random();
            var favNumber = r.Next(1,1000);
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("too high");
            }
            else
            {
                Console.WriteLine("SAME!");
            }

        }
    }
}