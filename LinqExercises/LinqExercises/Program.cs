namespace LinqExercises;

using System;

public class Author
{
    public int AuthorId { get; set; }

    public string Name { get; set; }
}

public class Book
{
    public int BookId { get; set; }
    
    public string Title { get; set; }
    
    public int AuthorId { get; set; }
    
    public bool IsAvailable { get; set; }
}

public class Loan
{
    public int LoanId { get; set; }
    
    public int BookId { get; set; }
    
    public DateTime LoanDate { get; set; }
    
    public DateTime? ReturnDate { get; set; }
}

public class LibraryData
{
    public List<Author> Authors { get; set; } = new List<Author>
    {
        new Author { AuthorId = 1, Name = "George Orwell" },
        new Author { AuthorId = 2, Name = "Jane Austen" },
        new Author { AuthorId = 3, Name = "F. Scott Fitzgerald" },
        new Author { AuthorId = 4, Name = "Agatha Christie" },
        new Author { AuthorId = 5, Name = "J.K. Rowling" }
    };

    public List<Book> Books { get; set; } = new List<Book>
    {
        new Book { BookId = 1, Title = "1984", AuthorId = 1, IsAvailable = true },
        new Book { BookId = 2, Title = "Animal Farm", AuthorId = 1, IsAvailable = false },
        new Book { BookId = 3, Title = "Pride and Prejudice", AuthorId = 2, IsAvailable = true },
        new Book { BookId = 4, Title = "Emma", AuthorId = 2, IsAvailable = false },
        new Book { BookId = 5, Title = "The Great Gatsby", AuthorId = 3, IsAvailable = true },
        new Book { BookId = 6, Title = "The Murder of Roger Ackroyd", AuthorId = 4, IsAvailable = true },
        new Book { BookId = 7, Title = "Murder on the Orient Express", AuthorId = 4, IsAvailable = false },
        new Book { BookId = 8, Title = "Harry Potter and the Sorcerer's Stone", AuthorId = 5, IsAvailable = true },
        new Book { BookId = 9, Title = "Harry Potter and the Chamber of Secrets", AuthorId = 5, IsAvailable = false }
    };

    public List<Loan> Loans { get; set; } = new List<Loan>
    {
        new Loan { LoanId = 1, BookId = 2, LoanDate = DateTime.Now.AddDays(-15), ReturnDate = DateTime.Now.AddDays(-10) },
        new Loan { LoanId = 2, BookId = 4, LoanDate = DateTime.Now.AddDays(-8), ReturnDate = null },
        new Loan { LoanId = 3, BookId = 7, LoanDate = DateTime.Now.AddDays(-30), ReturnDate = DateTime.Now.AddDays(-20) },
        new Loan { LoanId = 4, BookId = 9, LoanDate = DateTime.Now.AddDays(-25), ReturnDate = null }
    };
}

public class Program
{
    static void Main()
    {
        var libraryData = new LibraryData();

        // List all books that are currently available
        // method syntax
        var availableBooks1 = libraryData.Books.Where(book => book.IsAvailable);

        // query syntax
        var availableBooks2 = 
            from book in libraryData.Books
            where book.IsAvailable
            select book;

        // List all books that are currently on loan
        // method syntax
        var loanedBooks1 = libraryData.Books.Where(book => 
            libraryData.Loans.Any(
                loan => loan.BookId == book.BookId && loan.ReturnDate == null));

        // query syntax
        var loanedBooks2 =
            from book in libraryData.Books
            where libraryData.Loans.Any(loan => loan.BookId == book.BookId && loan.ReturnDate == null)
            select book;

        // Get a list of authors and the number of books they have written
        // method syntax
        var authorBooksCount1 = libraryData.Authors.Select(author => new
        {
            AuthorName = author.Name,
            BookCount = libraryData.Books.Count(book => book.AuthorId == author.AuthorId)
        });
        // query syntax
        var authorBooksCount2 =
            from author in libraryData.Authors
            select new
            {
                AuthorName = author.Name,
                BookCount = (
                    from book in libraryData.Books
                    where book.AuthorId == author.AuthorId
                    select book
                ).Count()
            };

        // Find the most recent loan for each book
        // method syntax
        var recentLoans1 = libraryData.Loans.GroupBy(loan => loan.BookId)
            .Select(grouped => grouped.OrderByDescending(loan => loan.LoanDate)).FirstOrDefault();

        // query syntax
        var recentLoans2 =
            (from loan in libraryData.Loans
            group loan by loan.BookId into grouped
            select new
            {
                BookId = grouped.Key,
                MostRecentLoan = (
                    from g in grouped
                    orderby g.LoanDate descending
                    select g
                ).FirstOrDefault()
            }).FirstOrDefault();

        // QUERY SYNTAX - JOIN
        // Join Books with Authors to List Each Book and its Author's Name:
        var booksWithAuthors =
            from book in libraryData.Books
            join author in libraryData.Authors on book.AuthorId equals author.AuthorId
            select new
            {
                BookTitle = book.Title,
                AuthorName = author.Name
            };

        // Find all books that have been loaned out at least once
        var booksLoanedatLeastOnce =
            from book in libraryData.Books
            join loan in libraryData.Loans
            on book.BookId equals loan.BookId
            group book by book.Title into grouped
            select new
            {
                BookTitle = grouped.Key,
                TimesLoaned = grouped.Count()
            };

        foreach (var book in booksLoanedatLeastOnce)
        {
            Console.WriteLine($"{book.BookTitle}: {book.TimesLoaned}");
        }

        // Join Multiple Tables (DS) - Books, Authors, and Loans to Get Detailed Loan History
        var booksLoanedHistory =
            from book in libraryData.Books
            join loan in libraryData.Loans
            on book.BookId equals loan.BookId
            join author in libraryData.Authors
            on book.AuthorId equals author.AuthorId
            select new
            {
                BookTitle = book.Title,
                AuthorName = author.Name,
                HistoryLoanDate = loan.LoanDate,
                HistoryReturnedDate = loan.ReturnDate
            };

        foreach (var book in booksLoanedHistory)
        {
            Console.WriteLine($"BookTitle = {book.BookTitle}\n"
                + $"AuthorName = {book.AuthorName}\n"
                + $"HistoryLoanDate = {book.HistoryLoanDate}\n"
                + $"HistoryReturnedDate = {book.HistoryReturnedDate}");
        }
    }
}
