using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem;

internal class Library
{
    private Catalog<Book> _bookCatalog;
    private List<Patron> _patrons;

    public Library()
    {
        _bookCatalog = new Catalog<Book>();
        _patrons = new List<Patron>();
    }
}