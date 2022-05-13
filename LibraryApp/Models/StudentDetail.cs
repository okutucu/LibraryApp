using System;
using LibraryApp.Enums;

namespace LibraryApp.Models
{
    public class StudentDetail : BaseEntity
    {
        public short SchoolNumber { get; set; }
        public Gender Gender { get; set; }
        public DateTime? BirthDay { get; set; }
        public int StudentID { get; set; }

        // Relational Properties

        public virtual Student Student { get; set; }

    }
}
