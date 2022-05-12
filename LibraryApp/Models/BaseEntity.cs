using System;
using LibraryApp.Enums;

namespace LibraryApp.Models
{
    public class BaseEntity
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? MofidiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public DataStatus Status { get; set; }

        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
    }
}
