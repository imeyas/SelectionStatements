using System;

namespace SwitchStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            var faveSubject = Console.ReadLine();
            var answer = faveSubject;
            switch(answer.ToLowerInvariant())
            {
                case "physical education":
                case "gym":
                case "pe":
                    Console.WriteLine($"{answer} it is: Your health is your wealth!");
                    break;

                case "science":
                case "biology":
                case "chemistry":
                case "lab":
                case "bio":
                case "chem":
                    Console.WriteLine($"{answer} it is: Stay true to the scientific method, scientist...");
                    break;

                case "mathematic":
                case "math":
                case "algebra":
                case "geometry":
                case "calculus":
                    Console.WriteLine($"{answer} it is: Get your Einstein on :-)");
                    break;

                case "psychology":
                case "psych":
                    Console.WriteLine($"{answer} it is: Shout-out Mr. Freud!");
                    break;

                case "music":
                case "band":
                case "music class":
                    Console.WriteLine($"{answer} it is: Let us hear something fresh right quick, LOL!");
                    break;

                default:
                    Console.WriteLine("Input not available, try again or click 'x' to exit...");
                    break;

                    
            }


        }
    }
}
