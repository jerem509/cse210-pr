using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int truegrade = int.Parse(grade);

        //letter assignemnt
        string lgrade;

        if (truegrade >= 90)
        {
            lgrade = "A";
        }
        else if (truegrade >= 80)
        {
            lgrade = "B";
        }
        else if (truegrade >= 70)
        {
            lgrade = "C";
        }
        else if (truegrade >= 60)
        {
            lgrade = "D";
        }
        else
        {
            lgrade = "F";
        }

        //print letter grade
        Console.WriteLine($"Your grade letter is {lgrade}.");

          //determining if the course is passed
        if (truegrade < 70)
        {
            Console.WriteLine("Better luck next time!");
        }
        else
        {
            Console.WriteLine("Congratulations! You have passed the course.");
        }
    }
}