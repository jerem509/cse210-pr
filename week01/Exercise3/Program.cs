using System;

class Program
{
    static void Main(string[] args)
    {   
        Random num = new Random();
        int magicNum = num.Next(1, 101);

        int guess = 199999;

        while ( guess != magicNum)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else 
            {
                Console.WriteLine("You guessed it!");
            }
        }



    }
}