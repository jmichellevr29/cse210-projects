class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
    public void AddComment(string name, string text)
    {
        _comments.Add(new Comment(name, text));
    }
    public int GetNumberofComments()
    {
        return _comments.Count;
    }
}