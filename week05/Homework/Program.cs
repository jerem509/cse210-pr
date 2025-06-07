using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment asgn = new Assignment("Helio Zak", "Inheritance Assignment");
        Console.WriteLine(asgn.GetSummary());
        Console.WriteLine();

        MathAssignment mathAsgn = new MathAssignment("Charles Jonel", "Math Assignment","Section 7.3", "Problems 8-19");
        Console.WriteLine(mathAsgn.GetSummary());
        Console.WriteLine(mathAsgn.GetHomeworkList());
        Console.WriteLine();
        
        WritingAssignment writingAsgn = new WritingAssignment("Charles Jonel", "Writing Assignment","The Causes of World War II by Mary Waters");
        Console.WriteLine(writingAsgn.GetWritingInformation());
        Console.WriteLine();
        

       
    }
}