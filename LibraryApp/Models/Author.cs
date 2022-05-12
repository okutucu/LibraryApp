using System.Collections.Generic;

namespace LibraryApp.Models
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Relational Properties

        public virtual List<Book> Books { get; set; }

    }
}
