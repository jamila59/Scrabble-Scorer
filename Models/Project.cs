using System;
using System.Collections.Generic;
using System.Linq;


namespace Project.Models
{
    class Program
    {
         public static void Main()
        {
            Console.WriteLine("Enter a word:");
            string input = Console.ReadLine();
            Scrabble console = new Scrabble(input);
            console.GetScore(input);
            // Console.WriteLine("Your Score:" + "" +);
        }
    }
}