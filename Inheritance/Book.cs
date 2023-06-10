public class Book : Loanable
{
    private string _isbn;
    private int _upc;

    public Book(string title, string isbn, int upc) : base(title)
    {
        _isbn = isbn;
        _upc = upc;
    }

    public void ShowBookDetails()
    {
        // base.Display();
        Console.WriteLine($"ISBN: {_isbn}, UPC: {_upc}");
    } 
}