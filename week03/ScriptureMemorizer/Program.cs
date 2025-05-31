using System;

class Program
{
    static void Main(string[] args)
    {
        Reference unique = new Reference("Alma", 32, 24);
        string text = "And now as I said concerning faith — faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.";
        if (unique.GetEndVerse()!= 0 && unique.GetEndVerse() < unique.GetStartVerse()) {
            Console.WriteLine("Your second verse must be greater than the first one.");
        }
        else {
            Scripture newScripture = new Scripture(unique, text);
            Console.WriteLine(newScripture.GetDisplayText());
            newScripture.HideRandomWords(4); 
        }
        
    }
}