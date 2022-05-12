using System;
using System.Collections.Generic;
using LibraryApp.Enums;

namespace LibraryApp.Models
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        // Relational Properties

        public virtual List<Operation> Operations { get; set; }
        public virtual StudentDetail StudentDetail { get; set; }
    }
}
