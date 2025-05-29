public class Video
{
    private string _title;
    private string _author;
    private float _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, float length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(string author, string text)
    {
        _comments.Add(new Comment(author, text));
    }
    public int GetNumComments()
    {
        return _comments.Count();
    }
    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nLength: {_length} seconds\nComments ({GetNumComments()}):");
        foreach (Comment c in _comments)
        {
            c.DisplayComment();
        }
    }
}