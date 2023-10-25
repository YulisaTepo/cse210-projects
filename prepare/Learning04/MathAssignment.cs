using System;
using System.ComponentModel.DataAnnotations;

public class MathAssignment : Assignment
{
    private double _textBookSection;
    private string _problems;
    public MathAssignment(string name, string topic, double section, string problems) : base(name, topic)
    {
        _textBookSection = section;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }
}