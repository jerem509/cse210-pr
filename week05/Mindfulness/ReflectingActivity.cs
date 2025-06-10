using System;

public class ReflectingActivity: Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description, List<string> prompts, List<string> questions): base(name, description)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind press Enter to continue.");
        Console.ReadLine();
        // Console.Clear();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    private string GetRandomPrompt() //string
    {
        int randPromptIndex= new Random().Next(0, _prompts.Count);
        return $"{_prompts[randPromptIndex]}";
    }

    private string GetRandomQuestion() //string
    {
        int randQuestionIndex= new Random().Next(0, _questions.Count);
        return _questions[randQuestionIndex];
    }

    private void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine(GetRandomPrompt());
    }

    private void DisplayQuestions()
    {
        Console.WriteLine("Now ponder on each of the following questions as they related to the experience.\n");
        Console.Write("You may begin in: ");
        //countdown and change of what is displayed each second
        ShowCountDown(5);
        Console.WriteLine("\n");
        //Get the current date and time
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        int remainingTime = GetDuration();
        //Display the random question : keep invoking GetRandomQuestion in a loop
        while (DateTime.Now < endTime && remainingTime >= 5)
        {
            string questn = GetRandomQuestion();
            Console.WriteLine($"--- {questn} ---");
            _questions.Remove(questn);
            ShowSpinner(5);
            Console.WriteLine();
            remainingTime -= 5;
        }
        
    } 
}