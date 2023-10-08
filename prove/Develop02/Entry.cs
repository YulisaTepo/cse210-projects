public class Entry
{
    public string _prompt;
    public string _date;
    public string _answer;

    public string DisplayString()
    {
        //Save prompt, date, answer and return it as an entry.
        string _entry = @$"> Date: {_date} - Prompt: {_prompt} 
Answer: {_answer}.";
        return _entry;
    }
}