using System.Collections.Generic;

namespace LibraryApp.Models
{
    public class Book : BaseEntity
    {
        public string BookName { get; set; }
        public short PageCount { get; set; }
        public int AuthorID { get; set; }
        public int BookTypeID { get; set; }

        // Relational Properties
        public virtual Author Author { get; set; }
        public virtual BookType BookType { get; set; }
        public virtual List<Operation> Operations { get; set; }
    }
}
