using System;
using System.Collections.Generic;
using System.Linq;
using LibraryApp.Context;
using LibraryApp.Models;
using LibraryApp.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Areas.Managment.Controllers
{
    [Area("Managment")]
    public class BookTypeController : Controller
    {

        IBookTypeRepository _repoBookType;
        public BookTypeController(IBookTypeRepository repoBookType)
        {
            _repoBookType = repoBookType;
        }
        public IActionResult BookTypeList()
        {
            List<BookType> bookTypes = _repoBookType.GetAll();
            return View(bookTypes);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookType bookType)
        {
            _repoBookType.Add(bookType);
            return RedirectToAction("BookTypeList", "BookType", new { area = "Managment" });
        }

        public IActionResult Edit(int id)
        {
            BookType bookType = _repoBookType.GetById(id);
            return View(bookType);
        }
        [HttpPost]
        public IActionResult Edit(BookType bookType)
        {
            _repoBookType.Update(bookType);
            return RedirectToAction("BookTypeList", "BookType", new { area = "Managment" });
        }

        public IActionResult HardDelete(int id)
        {
            _repoBookType.SpeacialDelete(id);
            return RedirectToAction("BookTypeList", "BookType", new { area = "Managment" });
        }
    }
}
