public class Scriptures
{
    string _verse;
    string _text;

    public Scriptures(string verse, string text)
    {
        _verse = verse;
        _text = text;
    }

    public string GetVerse()
    {
        return _verse;
    }

    public string GetText()
    {
        return _text;
    }
}