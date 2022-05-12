using System.Collections.Generic;

namespace LibraryApp.Models
{
    public class BookType :BaseEntity
    {
        public string Name { get; set; }

        // Relational Properties

        public virtual List<Book> Books { get; set; }
    }
}
