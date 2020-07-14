using System;

namespace PalindromeExercise
{
    class Program:WordSmith
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            WordSmith call = new WordSmith();
            call.PalFinder("Racecar");
        }
    }
}
