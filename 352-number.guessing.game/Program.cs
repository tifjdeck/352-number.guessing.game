/* Number Guessing Game
 * 01/20/2023
 * Tiffany Decker */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("I am thinking of a number between 0 and 100.");

        Random rnd = new Random();
        int RandNum = rnd.Next(0, 101);
        //This code was found at https://www.tutorialsteacher.com/articles/generate-random-numbers-in-csharp

        Console.WriteLine("Take a guess: ");
        int UserGuess = Convert.ToInt32(Console.ReadLine());
        //I found out how to convert ints to strings here: https://www.w3schools.com/cs/cs_user_input.php 

        int NumGuess = 0;
        for (int x = 0; x < 30; x++)
        {
            if (UserGuess < RandNum)
            {
                Console.WriteLine("Too Low! Guess again: ");
                NumGuess++;
                UserGuess = Convert.ToInt32(Console.ReadLine());
            }
            else if (UserGuess > RandNum)
            {
                Console.WriteLine("Too High! Guess again: ");
                NumGuess++;
                UserGuess = Convert.ToInt32(Console.ReadLine());
            }

            else if (UserGuess == RandNum)
            {
                Console.WriteLine("Just Right!");
                break;
            }
        }

        Console.WriteLine("This attempt took you " + NumGuess + " tries!");
        Console.ReadKey();
    }
}
}