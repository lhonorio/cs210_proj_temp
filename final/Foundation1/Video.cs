public class Video
{
    string _title;
    string _author;
    int _length;
    List <Comments> _comments = new List<Comments>();


    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }


    public void AddComments(string author, string text)
    {
        Comments comment = new Comments(author, text);
        
        _comments.Add(comment);
    }
    
    public int CountComments()
    {
        return _comments.Count;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public string GetLength()
    {
        int minutes = _length / 60;
        int seconds = _length % 60;
        
        return $"{minutes}:{seconds}";
    }

    public void DisplayComments()
    {
        foreach (Comments comment in _comments)
        {
            string fullComment = $"{comment.GetCommentAuthor()}\n{comment.GetComment()}";

            Console.WriteLine($"{comment.GetCommentAuthor()}\n{comment.GetComment()}\n");
        }
    }
}