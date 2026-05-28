public class Video
{

    public string _name;
    public string _author;
    public int _length;
    public List<Comment> _comments;

    public int GetCommentAmount()
    {
        return _comments.Count;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Video Title: {_name}\nVideo Author: {_author}\nVideo Length: {_length}\nNumber of Comments: {GetCommentAmount()}");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}