public class Dvd : Loanable
{

    public Dvd(string title) : base(title)
    {
        _title = title;
    }
    
    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Title: {_title}");
    }
}