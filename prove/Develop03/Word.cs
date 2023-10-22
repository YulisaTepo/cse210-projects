public class Word
{
    private string _word;
    private bool _IsHidden;
    
    public Word(string word)
    {
        _word = word;
        //_IsHidden = false;
    }
    public bool GetIsHidden() // This is only for the IscompleteHidden method on Scripture. 
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
        {
            string convertedWord = string.Concat(Enumerable.Repeat("_", _word.Length));
            return convertedWord;
        }
    } 
    public void Hide() // This will set _hidden to false
    {_IsHidden = true;}
}