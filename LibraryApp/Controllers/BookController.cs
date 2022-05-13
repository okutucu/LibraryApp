using System;
using System.Collections.Generic;
using System.Linq;
using LibraryApp.Context;
using LibraryApp.Dto;
using LibraryApp.Models;
using LibraryApp.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp.Controllers
{
    public class BookController : Controller
    {
      
        IBookRepository _repoBook;
        IAuthorRepository _repoAuther;
        IBookTypeRepository _repoTypeBook;
        public BookController(IBookRepository repoBook,IAuthorRepository repoAuther, IBookTypeRepository repoTypeBook)
        {
            _repoBook = repoBook;
            _repoAuther = repoAuther;
            _repoTypeBook = repoTypeBook;
        }
        public IActionResult BookList()
        {
            List<Book> books = _repoBook.GetBooks();
            return View(books);
        }
        public IActionResult Create()
        {
            List<AuthorDto> authors = _repoAuther.SelectAuthorDto();

            List<BookTypeDto> bookTypes = _repoTypeBook.SelectBookTypeDto();

            return View((new Book(), authors, bookTypes));
        }

        [HttpPost]
        public IActionResult Create([Bind(Prefix = "Item1")] Book book)
        {
            _repoBook.Add(book);
            return RedirectToAction("BookList");
        }

        public IActionResult Edit(int id)
        {
            Book book = _repoBook.GetById(id);

            List<AuthorDto> authors = _repoAuther.SelectAuthorDto();

            List<BookTypeDto> bookTypes = _repoTypeBook.SelectBookTypeDto();

            return View((new Book(), authors, bookTypes));
        }

        [HttpPost]
        public IActionResult Edit([Bind(Prefix = "Item1")] Book book)
        {
            _repoBook.Update(book);

            return RedirectToAction("BookList");
        }
    }
}
