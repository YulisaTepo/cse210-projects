using System.Net;
using System.Text;


public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    private int GetNumComments() 
    {
        int nunComments = _comments.Count;
        return nunComments;
    }
    public string GetCommentList()
    {
        StringBuilder stringB = new StringBuilder();
        foreach (var comment in _comments)
        {
            stringB.AppendLine(comment.toString());
        }
        return stringB.ToString();
    }
    public string toString()
    {
        return $"Title: {_title} | Author: {_author} | Length: {_length} seconds | Number of comments: {GetNumComments()}";
    }
}