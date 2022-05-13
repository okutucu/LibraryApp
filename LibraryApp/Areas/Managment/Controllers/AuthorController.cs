﻿using System.Collections.Generic;
using LibraryApp.Models;
using LibraryApp.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Areas.Managment.Controllers
{
    [Area("Managment")]
    public class AuthorController : Controller
    {
        IAuthorRepository _repoAuthor;
        public AuthorController(IAuthorRepository repoAuthor)
        {
            _repoAuthor = repoAuthor;
        }
        public IActionResult AuthorList()
        {

            List<Author> authors = _repoAuthor.GetActives();
            return View(authors);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Author author)
        {
            _repoAuthor.Add(author);
            return RedirectToAction("AuthorList", "Author", new {area = "Managment"});
        }

        public IActionResult Edit(int id)
        {
            Author author = _repoAuthor.GetById(id);
            return View(author);
        }

        [HttpPost]
        public IActionResult Edit(Author author)
        {
            _repoAuthor.Update(author);

            return RedirectToAction("AuthorList", "Author", new { area = "Managment" });
        }

        public IActionResult Delete(int id)
        {
            _repoAuthor.Delete(id);
            return RedirectToAction("AuthorList", "Author", new { area = "Managment" });
        }
    }
}
