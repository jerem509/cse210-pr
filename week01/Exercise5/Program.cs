using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            //Displays the message, "Welcome to the Program!"
            Console.WriteLine("Welcome to the program!");
        }

        DisplayWelcome();

        static string PromptUserName()
        {
            //Asks for and returns the user's name (as a string)
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        string username = PromptUserName();

        static int PromptUserNumber()
        {
            //Asks for and returns the user's favorite number (as an integer)
            Console.Write("Please enter your favorite number: ");
            int favoriteNumber = int.Parse(Console.ReadLine());
            return favoriteNumber;
        }

        int usernumber = PromptUserNumber();

        static int SquareNumber(int number)
        {
            int squaredNumber = (int)Math.Pow(number, 2);
            return squaredNumber;
        }

        int squaredNumber = SquareNumber(usernumber);

        static void DisplayResult(string usrname, int sqrdNumber)
        {
            Console.WriteLine($"{usrname}, the square of your number is: {sqrdNumber}");
        }

        DisplayResult(username, squaredNumber);

        //Console.WriteLine("Hello World! This is the Exercise5 Project.");
    }
}