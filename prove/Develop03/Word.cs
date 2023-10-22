public class Word
{
    private string _word;
    private bool _IsHidden;
    
    public Word(string word)
    {
        _word = word;
    }
    public bool GetIsHidden() 
    {
        if (_IsHidden == true)
        {
            return true;
        } 
        else
        {
            return false;
        }
    } 

    public string GetRenderedText() // Display the word or underscores.
    {
        if (_IsHidden == false)
        {
            return _word;
        }
        else
        {   //This syntax replace the word (i.e. "Hello") to underscores (i.e. "-----") with the exact numbers 
            //of the characteres that the word has. 
            string convertedWord = string.Concat(Enumerable.Repeat("_", _word.Length)); 
            return convertedWord;
        }
    } 
    public void Hide()
    {_IsHidden = true;}
}