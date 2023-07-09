public class Comments
{
    string _commentAuthor;
    string _text;


    public Comments(string commentAuthor, string text)
    {
        _commentAuthor = commentAuthor;
        _text = text;
    }

    
    public string GetCommentAuthor()
    {
        return _commentAuthor;
    }

    public string GetComment()
    {
        return _text;
    }
}