using System;

public class BreathingActivity: Activity
{
    public BreathingActivity(string name, string description) : base(name, description) {}

    public void Run()
    {
        DisplayStartingMessage();
        //Get the current date and time
        int remainingTime = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(remainingTime);
        //Display the random question : keep invoking GetRandomQuestion in a loop
        while (DateTime.Now < endTime)
        {
            List<string> breathingPhases= new List<string> {"Breathe in...", "Breathe out..."};
            int phaseIndex = 0;
            while (remainingTime >= 5)
            {
                Console.Write(breathingPhases[phaseIndex]);
                ShowCountDown(5);
                if (phaseIndex == 1)
                {
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("");
                }
                remainingTime -= 5;
                phaseIndex = (phaseIndex + 1) % breathingPhases.Count;
            }
        }
        DisplayEndingMessage();
    }
}