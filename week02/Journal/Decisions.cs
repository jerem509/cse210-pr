using System;
using System.Collections.Generic;

public class Decisions
{

    //This program gives the user the opportunity to save the entries if any while quitting the program
    public static void QuitProgram ()
    {
        if (Journal.GetEntriesListCount() >= 1) 
        {
            Console.Write("Do you want to save your entries?\n\tType 'Yes' to save. ");
            string saveEntries = Console.ReadLine().ToLower();
            if (saveEntries == "yes")
            {
                Journal.SaveToFile();
            }
            else
            {
                Console.WriteLine("You quit.");
                Console.WriteLine();
            }
        }
        else 
        {
            Console.WriteLine("You quit.");
            Console.WriteLine();
        }
    }

    public static void UserDecision ()
    {

        //declaring a variable related to the decision to be made by the user in the suggested choices
        int decision = -1;

        // Begin a loop to repeatedly ask the user what they want to do
        do
        {
            Console.WriteLine("Please select one of the following choices:\n1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
            Console.Write("What would you like to do? ");

            // Attempt to read the user's input and convert it to an integer
            try 
            {
                decision = int.Parse(Console.ReadLine());
                Console.WriteLine();

                // Perform an action based on the user's decision
                if (decision == 1)
                {
                    Journal.AddEntry();
                }
                else if (decision == 2)
                {
                    Journal.DisplayAll();
                }
                else if (decision == 3)
                {
                    Journal.LoadFromFile();
                } 
                else if (decision == 4)
                {
                    Journal.SaveToFile();
                }
                else if (decision == 5)
                {
                    Decisions.QuitProgram();
                }
            }
            catch (FormatException)
            {
                // If input is not a valid integer, inform the user
                Console.WriteLine("Please enter a valid number as per the choices above.");
            }

 
        }
        //Loop continues until user types 5 chooses to quit
        while (decision != 5);

    }
}