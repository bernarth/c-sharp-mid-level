namespace LibraryManagementSystem;

internal class Patron
{
    private string _name;
    private List<Book> _borrowedBooks;

    public Patron(string name)
    {
        _name = name;
        _borrowedBooks = new List<Book>();
    }

    public void AddBook(Book book)
    {
        _borrowedBooks.Add(book);
    }

    public void CheckBorrowedBooks(string memberName)
    {

    }
}
