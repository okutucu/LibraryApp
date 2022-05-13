using System;
using LibraryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Initializer
{
    public static class DataInitializer
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            string password1 = BCrypt.Net.BCrypt.HashPassword("123");
            string password2 = BCrypt.Net.BCrypt.HashPassword("1234");
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser() { ID = 1, UserName = "admin", Password = password1, Role = Enums.Roles.admin },
                new AppUser() { ID = 2, UserName = "oguz", Password = password2, Role = Enums.Roles.user }
                );

            modelBuilder.Entity<Student>().HasData(
                new Student() { ID = 1, FirstName = "Serhan", LastName = "Kılıç", PhoneNumber = "5555555" },
                new Student() { ID = 2, FirstName = "Kaan", LastName = "Kutucu", PhoneNumber = "33333" },
                new Student() { ID = 3, FirstName = "Özgür", LastName = "Cansız", PhoneNumber = "123456" },
                new Student() { ID = 4, FirstName = "Zeynep", LastName = "Kurt", PhoneNumber = "4444444" }

                );
            modelBuilder.Entity<StudentDetail>().HasData(
                new StudentDetail() { ID = 1, StudentID = 1, SchoolNumber = 244, Gender = Enums.Gender.Man },
                new StudentDetail() { ID = 2, StudentID = 2, SchoolNumber = 123, Gender = Enums.Gender.Man },
                new StudentDetail() { ID = 3, StudentID = 3, SchoolNumber = 444, Gender = Enums.Gender.Man },
                new StudentDetail() { ID = 4, StudentID = 4, SchoolNumber = 122, Gender = Enums.Gender.Woman}
                );
        }
    }
}
