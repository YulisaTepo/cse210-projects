using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Comment
{
    private string _personName;
    private string _textComment;
    
    public Comment(string name, string text)
    {
        _personName = name;
        _textComment = text;
    }
    public string toString()
    {
        return $"- User: {_personName} \n  Comment: {_textComment}";
    }
}