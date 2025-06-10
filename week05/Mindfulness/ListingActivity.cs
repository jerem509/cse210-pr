using System;

public class ListingActivity: Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description, int count, List<string> prompts): base(name, description)
    {
        _prompts = prompts;
    }
    

    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        GetListFromUser();
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        int randPromptIndex = new Random().Next(0, _prompts.Count);
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[randPromptIndex]} ---");
        Console.Write("\nYou may begin in ");
        ShowCountDown(5);   
    }

    public List<string> GetListFromUser() //List<string>
    {
        Console.WriteLine();
        List<string> userList = new List<string>();
        //Get the current date and time
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        //Display the random question : keep invoking GetRandomQuestion in a loop
        while (DateTime.Now < endTime)
        {
            Console.Write(" > ");
            string entry = Console.ReadLine();
            userList.Add(entry);
            _count++; 
        }
        Console.WriteLine();
        Console.WriteLine($"You listed {_count} item(s).");

        return userList;
    }
}