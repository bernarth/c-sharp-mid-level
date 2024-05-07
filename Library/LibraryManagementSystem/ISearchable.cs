using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem;

internal interface ISearchable
{
    List<Book> SearchByTitle(string title);
    List<Book> SearchByAuthor(String author);
}
