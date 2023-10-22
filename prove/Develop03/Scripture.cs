public class Scripture
{
    private Reference _reference;
    private List<Word> _scripture = new List<Word>();
    public Scripture(Reference reference, string scripture)
    {
        _reference = reference;

        string[] words = scripture.Split(" ");
        foreach (string word in words)
        {
            _scripture.Add(new Word(word));
        }
    }

    public void DisplayRenderedText()
    {
        Console.WriteLine(_reference.GetReference());
        foreach (Word word in _scripture)
        {
            Console.Write(word.GetRenderedText() + " ");
        }
    }

    public void HideWords()
    {
        for (int i = 0; i < 3; i++)
        {
            while (true) //This while loop will just hide the words that are not already hidden. 
            {
                Random word = new Random();
                int index = word.Next(_scripture.Count());
                
                if (_scripture[index].GetIsHidden() == false)
                {
                    _scripture[index].Hide();
                    break;
                }
                
            }
        }
    }
    public bool IsCompletelyHidden()
    {
        int counter = 0;
        foreach (Word word in _scripture)
        {
            if (word.GetIsHidden() == true)
            {
                counter = counter + 1;
            }
        }
        if (counter == _scripture.Count())
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}