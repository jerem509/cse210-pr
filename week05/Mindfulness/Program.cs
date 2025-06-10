using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Start breathing activity \n2. Start reflecting activity \n3. Start listing activity \n4. Quit ");
        Console.Write("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine();

        List<string> refPrompts = PromptsAndQuestions.ReflectingPrompts();
        List<string> questions = PromptsAndQuestions.ReflectingQuestions();
        List<string> listingActivityPrompts = PromptsAndQuestions.ListingPrompts();

        //Object and methods to call based on the user activity choice
        switch (choice)
        {
            case 1: //breathing activity chosen
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathingActivity.Run();
                break;
            case 2: //reflecting activity chosen
                ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", refPrompts, questions);
                reflectingActivity.Run();
                break;
            case 3: //listing activity chosen
                ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 4, listingActivityPrompts);
                listingActivity.Run();
                break;
            case 4: //user chooses to quit
                break;
            default: //any other input entered by the user
                Console.WriteLine("Invalid choice. Please select a valid option.");
                break;
        }
    }
}