using System;
using System.Collections.Generic;

public class PromptGenerator
{
    //create the list of prompts template to receive the prompts
    public List<string> _prompts = new List<string>();

    //function to return the random prompts selected randomly from the list
    public string GetRandomPrompt()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        
        //select a prompt index randomly from the list of prompts
        int randomPromptNumber = new Random().Next(0, _prompts.Count);
       
        //return the prompt found at the index
        return(_prompts[randomPromptNumber]);
    }
}
