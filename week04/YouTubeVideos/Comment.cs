using System;
using System.Collections.Generic;

public class Comment
{
    private string _name = "";
    private string _text = "";

    public Comment () {}
    public Comment(string name, string comment)
    {
        _name = name;
        _text = comment;
    }

    public string GetDisplayComment()
    {
        if (_name != "")
        {
            return $"{_name}: {_text}";
        }
        else {
            return "";
        }
    }
}