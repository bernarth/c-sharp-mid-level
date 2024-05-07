namespace LibraryManagementSystem;

internal class Book : IBorrowable
{
    private readonly string _title;
    private readonly string _autor;
    private readonly string _isbn;
    private bool _isAvailable;

    public Book(string title, string autor, string isbn)
    { 
        _title = title;
        _autor = autor;
        _isbn = isbn;
        _isAvailable = true;
    }

    public void Checkout(Patron patron)
    {
        throw new NotImplementedException();
    }

    public void ReturnItem(Patron patron)
    {
        throw new NotImplementedException();
    }
}
