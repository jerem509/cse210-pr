using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference newReference, string text)
    {
        _reference = newReference;
        _words = text.Split(" ").Select(word => new Word(word)).ToList();
    }

    public int GetListLength()
    {
        return _words.Count;
    }


    public void HideRandomWords(int numberToHide)
    {   
        int x = GetListLength(); 
        //use the variable to make a new list for each object index: a list of indexes
        List<int> indexes = new List<int>();
        for (int k = 0; k < x; k++){
            indexes.Add(k);
        }

        do
        {
            //Console.WriteLine(string.Join(", ", indexes)); //display the indexes list on one line
            //Suggestion
            Console.WriteLine();
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            Console.WriteLine();
            string decision = Console.ReadLine();
            if (decision == "")
            { 
                int val = 0;
                if (x < numberToHide) {
                    val = x;
                }
                else {val = numberToHide;};
                int num = new Random().Next(1, val);
                //repeat the loop to select a number of word objects and modify it
                for (int i=1; i <= num; i++) 
                {
                    //get an index randomly from the list of indexes
                    int randNum = new Random().Next(0, indexes.Count);
                    int randWordIndex = indexes[randNum]; 
                                         
                    //if the word object in _words is not hidden, do all this:
                    //get its characters
                    string wordStr = _words[randWordIndex].GetWordText();
                    //replace them with underscore '_'
                    var replaced = wordStr.Select(c => '_');
                    //make an array of '_', then join them into a string
                    string nuText = new string(replaced.ToArray());
                    //replace the old word object with the new word object made of underscores.
                    _words[randWordIndex] = new Word(nuText);                     
                    //remove the used index from the list of indexes
                    indexes.Remove(randWordIndex);
                    x = x-1;
                }
                Console.WriteLine(GetDisplayText());
            }
            else if (decision.ToLower() == "quit")
            {
                break;
            } 
        }
        while (x != 0 || IsCompletelyHidden() == false);
    }

    public string GetDisplayText()
    {
        string sentence = "";
        _words.ForEach(word => sentence = sentence + " " + word.GetDisplayText());
        return $"{_reference.GetDisplayText()} : {sentence}";
    }

    private bool IsCompletelyHidden()
    {
        bool listCompletelyHidden = _words.All(word => word.IsHidden() == true);
        return listCompletelyHidden;
    }
}