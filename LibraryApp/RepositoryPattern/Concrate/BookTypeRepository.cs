using System.Collections.Generic;
using System.Linq;
using LibraryApp.Context;
using LibraryApp.Dto;
using LibraryApp.Models;
using LibraryApp.RepositoryPattern.Base;
using LibraryApp.RepositoryPattern.Interfaces;

namespace LibraryApp.RepositoryPattern.Concrate
{
    public class BookTypeRepository : Repository<BookType>, IBookTypeRepository
    {
        public BookTypeRepository(MyDbContext db) : base(db)
        {
        }

        public List<BookTypeDto> SelectBookTypeDto()
        {
           return table.Where(x => x.Status != Enums.DataStatus.Deleted)
             .Select(x =>
             new BookTypeDto()
             {
                 Name = x.Name,
                 ID = x.ID
             }).ToList();
        }

      
    }
}
