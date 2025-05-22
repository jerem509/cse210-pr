using System;

class Program
{
    static void Main(string[] args)
    {
        //Showing Creativity :
        // - added a regular expression in SaveToFile() and LoadFromFile() in Journal class as a filename validation process.
        // - added an option that gives the user an opportunity to save the entries after choosing to Quit. 
        //   See class Decisions.

        Console.WriteLine("Welcome to the program!");

        //Inviting to select one of many experiences offered by the program.
        Decisions.UserDecision();
    }
}