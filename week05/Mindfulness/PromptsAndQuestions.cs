using System;
using System.Collections.Generic;

public class PromptsAndQuestions
{
    //===========================================
    //Reflecting Activity
    // ------------------------------------------
    // Generate random prompt
    public static List<string> ReflectingPrompts()
    {
        List<string> refPrompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
        };
        return refPrompts;
    }


    //Generate list of questions
    //-------------------------------------------
    public static List<string> ReflectingQuestions()
    {
        List<string> questions = new List<string> {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        return questions;
    }
    //===========================================

    //===========================================
    //Listing Activity Prompts
    // ------------------------------------------
    public static List<string> ListingPrompts()
    {
        List<string> listingActivityPrompts = new List<string> {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        return listingActivityPrompts;
    }
    //===========================================
}