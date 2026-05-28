using System.Net;

public class Comment
{
    public string _author;
    public string _commentText;

    public Comment(string author, string text)
    {
        _author = author;
        _commentText = text;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"Author: {_author}\nText: \"{_commentText}\"");
    }
}