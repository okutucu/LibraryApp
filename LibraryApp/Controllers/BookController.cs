using System;
using System.Collections.Generic;
using System.Linq;
using LibraryApp.Context;
using LibraryApp.Dto;
using LibraryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Controllers
{
    public class BookController : Controller
    {
        MyDbContext _db;
        public BookController(MyDbContext db)
        {
            _db = db;
        }
        public IActionResult BookList()
        {
            List<Book> books = _db.Books.Where(b => b.Status != Enums.DataStatus.Deleted).Include(b => b.Author).Include(b => b.BookType).ToList();
            return View(books);
        }
        public IActionResult Create()
        {
           List<AuthorDto> authors = _db.Authors.Where(x => x.Status != Enums.DataStatus.Deleted)
                .Select(
                x => new AuthorDto(){
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    ID = x.ID
                }).ToList();

            List<BookTypeDto> bookTypes = _db.BookTypes.Where(x => x.Status != Enums.DataStatus.Deleted)
             .Select(x =>
             new BookTypeDto()
             {
                 Name = x.Name,
                 ID = x.ID
             }).ToList();

            return View((new Book(), authors, bookTypes));
        }

        [HttpPost]
        public IActionResult Create([Bind(Prefix = "Item1")] Book book)
        {
            _db.Books.Add(book);
            _db.SaveChanges();
            return RedirectToAction("BookList");
        }

        public IActionResult Edit(int id)
        {
            Book book = _db.Books.Find(id);

            List<AuthorDto> authors = _db.Authors.Where(x => x.Status != Enums.DataStatus.Deleted)
               .Select(
               x => new AuthorDto()
               {
                   FirstName = x.FirstName,
                   LastName = x.LastName,
                   ID = x.ID
               }).ToList();

            List<BookTypeDto> bookTypes = _db.BookTypes.Where(x => x.Status != Enums.DataStatus.Deleted)
             .Select(x =>
             new BookTypeDto()
             {
                 Name = x.Name,
                 ID = x.ID
             }).ToList();

            return View((new Book(), authors, bookTypes));
        }

        [HttpPost]
        public IActionResult Edit([Bind(Prefix = "Item1")] Book book)
        {
            book.Status = Enums.DataStatus.Updated;
            book.MofidiedDate = DateTime.Now;
            _db.Books.Update(book);
            _db.SaveChanges();

            return RedirectToAction("BookList");
        }
    }
}
