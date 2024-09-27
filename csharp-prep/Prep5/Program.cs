using System;

class Program
{
    static void Main(string[] args)
    {
        //Main functions
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }

    //Functions
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }

        static int SquareNumber(int i)
        {
            int squared = i * i;
            return squared;
        }

        static void DisplayResult(string userName, int number)
        {
            Console.WriteLine($"{userName}, the square of your number is {number}");
        }
}