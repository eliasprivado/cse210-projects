using System;

class Program
{
    static void Main(string[] args)
    {
        //For parts 1 and 2
        //Console.WriteLine("What is the magic number");
        //string userNumber = Console.ReadLine();
        //int number = int.Parse(userNumber);
        Console.WriteLine("Try to guess the magic number! (Anywhere from 1 to 100)");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        int guess = -1;
        int attempts = 0;

        while (guess != number)
        {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());
            attempts = attempts + 1;

            if (guess > number)
            {
            Console.WriteLine("Lower");
            }

            else if (guess < number)
            {
            Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("Correct!");
            }
        }
        Console.WriteLine($"It took you {attempts} attempt(s) to guess correctly.");
    }
}