using System;

namespace LibraryApp.Models
{
    public class Operation : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int StudentID { get; set; }
        public int BookID { get; set; }

        // Relational Properties
        public virtual Student  Student { get; set; }
        public virtual Book  Book { get; set; }
    }
}
