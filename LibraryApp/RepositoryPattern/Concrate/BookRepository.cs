using System.Collections.Generic;
using System.Linq;
using LibraryApp.Context;
using LibraryApp.Models;
using LibraryApp.RepositoryPattern.Base;
using LibraryApp.RepositoryPattern.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.RepositoryPattern.Concrate
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(MyDbContext db) : base(db)
        {
        }

        public List<Book> GetBooks()
        {
            return table.Where(b => b.Status != Enums.DataStatus.Deleted).Include(b => b.Author).Include(b => b.BookType).ToList();
        }
    }
}
