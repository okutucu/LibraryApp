using System.Collections.Generic;
using System.Linq;
using LibraryApp.Context;
using LibraryApp.Dto;
using LibraryApp.Models;
using LibraryApp.RepositoryPattern.Base;
using LibraryApp.RepositoryPattern.Interfaces;

namespace LibraryApp.RepositoryPattern.Concrate
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(MyDbContext db) : base(db)
        {
        }

        public List<AuthorDto> SelectAuthorDto()
        {
            return table.Where(x => x.Status != Enums.DataStatus.Deleted)
                .Select(
                x => new AuthorDto()
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    ID = x.ID
                }).ToList();
        }
    }
}
