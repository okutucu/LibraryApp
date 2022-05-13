using System.Collections.Generic;
using LibraryApp.Dto;
using LibraryApp.Models;

namespace LibraryApp.RepositoryPattern.Interfaces
{
    public interface IBookTypeRepository : IRepository<BookType>
    {
        List<BookTypeDto> SelectBookTypeDto();
    }
}
