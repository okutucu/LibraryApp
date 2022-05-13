using System.Collections.Generic;
using LibraryApp.Models;

namespace LibraryApp.RepositoryPattern.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        List<Book> GetBooks();
    }
}
