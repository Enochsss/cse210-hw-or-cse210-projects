public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }

    public string GetDisplayText()
    {
        return $"{_title} by {_author} ({_lengthInSeconds / 60} minutes)";
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.GetDisplayText());
        }
    }
}