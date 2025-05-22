using System;
using System.Collections.Generic;

public class Entry
{
    //variables to create the entries
    public string _date; //to store the date of the entry; short date.
    public string _promptText; //store the prompt to be received from the prompt generator.
    public string _entryText; //store the ftext entered by the user.

    public Entry() {}

    //function to display the entries
    public void Display()
    {  
        if (Journal.GetEntriesListCount() > 0)
        {
            //storing the text to display in a string variable
            foreach(Entry entry in Journal._entries)
            {
                Console.WriteLine($"Date: {entry._date}: Prompt: {entry._promptText} \nResponse: {entry._entryText}\n");
            }
        }
        else
        {
            Console.WriteLine("There is no entry in the journal to display. Enter some first.");
            Console.WriteLine();
        }
        
    }
}