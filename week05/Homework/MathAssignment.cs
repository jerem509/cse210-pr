using System;

public class MathAssignment : Assignment
{
    private string _textBookSection = "";
    private string _problems = "";

    public MathAssignment (string StudentName, string topic, string textBookSection, string problems) : base(StudentName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public string GetHomeworkList() 
    {
        return $"{_textBookSection} {_problems}";
    }
}