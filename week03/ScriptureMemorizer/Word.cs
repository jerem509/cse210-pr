using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public string GetWordText () 
    {
        return _text;
    }

  
    private void Hide()
    {
        _isHidden = true;   
    }

    private void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        bool hiddenWord = Regex.IsMatch(_text, "^_+$");
        if (hiddenWord == true) {
            Hide();
            return _isHidden;
        }
        else {
            Show();
            return _isHidden;
        }
        
    }

    public string GetDisplayText()
    {
        return _text;
    }
}