using System;

public class Activity
{
    public string _name;
    public string _description;
    public int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    private void SetDuration()
    {
        int yourTime = 0;
        while (yourTime < 10)
        {
            yourTime = int.Parse(Console.ReadLine());
            if (yourTime < 10)
            {
                Console.WriteLine("Time must be greater than 10 seconds.");
                Console.Write("Enter a valid length of session: ");
            }
        }
        //set duration
        _duration = yourTime;     
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine($"{_description}");
        Console.Write($"How long, in seconds, would you like for your sessions: ");
        SetDuration();
        Console.Clear();
        Console.Write("Get ready");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
            //Console.Write("\b \b");
        };
        Console.WriteLine("\n");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Good job!");
        Thread.Sleep(1000);
        Console.WriteLine($"You have completed {_duration} seconds of {_name}.");
    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        List<string> symbols = new List<string> { "|", "/", "-", "\\", "|", "/", "-", "\\" };
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(symbols[i]);
            Thread.Sleep(100);
            Console.Write("\b \b");
            i++;

            if (i >= symbols.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i); //what is displayed in the console
            Thread.Sleep(1000); // 1 second
            Console.Write("\b \b");
        }
    }
}