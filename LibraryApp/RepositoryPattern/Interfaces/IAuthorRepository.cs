using System.Collections.Generic;
using LibraryApp.Dto;
using LibraryApp.Models;

namespace LibraryApp.RepositoryPattern.Interfaces
{
    public interface IAuthorRepository : IRepository<Author>
    {
        List<AuthorDto> SelectAuthorDto();
    }
}
