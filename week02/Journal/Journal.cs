using System;
using System.IO; 
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Journal 
{
    public static List<Entry> _entries = new List<Entry>();

    public Journal() 
    {

    }   

    public static int GetEntriesListCount ()
    {
        return _entries.Count;
    }


    public static void AddEntry ()
    {       
        //create a new entry
        Entry newEntry = new Entry();

        //add new Entry object to list of _entries
        _entries.Add(newEntry);

        //get the current date and save it in the Entry variable list.
        DateTime currentDate = DateTime.Now;
        newEntry._date = currentDate.ToShortDateString();

        //get prompt from the prompt generator and store it
        PromptGenerator prompts = new PromptGenerator();        
        newEntry._promptText = prompts.GetRandomPrompt(); 
        Console.WriteLine(newEntry._promptText);

        //user text entry
        newEntry._entryText = Console.ReadLine();
        Console.WriteLine();
    }

    public static void SaveToFile () 
    {
        if (GetEntriesListCount() >= 1)
        {
            Console.WriteLine("What is the filename?");
            string filename = Console.ReadLine();


            string pattern = @"^[A-Za-z]{3,}[0-9]*\.(txt|csv)$";
            if (Regex.IsMatch(filename, pattern, RegexOptions.IgnoreCase))
            {
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    //iterating through each entry in the list of entries
                    foreach(Entry entry in _entries)
                    {
                        // adding each line of entry to 'filename'.
                        outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
                    }           
                }
                //informing user entries are saved to the desired file.
                Console.WriteLine($"Entries saved to file {filename}");
            }
            else
            {
                Console.WriteLine("Invalid filename. It must start with at least 3 letters and end with '.txt'. No whitespace allowed.");
            }  
        }
    }

    public static void DisplayAll () 
    {
        Entry xEntry = new Entry();
        xEntry.Display();
    }

    public static void LoadFromFile ()
    {
        Console.WriteLine("Enter the name of the file to load data from: ");
        string filename = Console.ReadLine();
        Console.WriteLine();
        string pattern = @"^[A-Za-z]{3,}[0-9]*\.(txt|csv)$";
        if (Regex.IsMatch(filename, pattern, RegexOptions.IgnoreCase))
        {
            string[] lines = System.IO.File.ReadAllLines(filename);

            //clear the list of entries
            _entries.Clear();

            //iterate through each line of the file and append them to the list of entries
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");

                //create a new entry
                Entry newEntry = new Entry(); 

                //add new Entry object to list of _entries
                _entries.Add(newEntry);

                newEntry._date = parts[0];
                newEntry._promptText = parts[1];
                newEntry._entryText = parts[2];
            }
        }
        else 
        {
            Console.WriteLine("Invalid filename. It must start with at least 3 letters and end with '.txt'. No whitespace allowed.");
        }
    }
}