using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new LibaryDbContext())
            {
               var books = db.Book.ToList();
            return View(books);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            using (var db = new LibaryDbContext())
            {
                db.Add(book);
                db.SaveChanges();
                    
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            if(!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            using (var db = new LibaryDbContext())
            {
                var editBook = db.Book.Find(id);

                return View(editBook);
            }
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if(!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            using (var db = new LibaryDbContext())
            {
                db.Update(book);
                db.SaveChanges();

            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            using (var db = new LibaryDbContext())
            {
                var bookToDel = db.Book.Find(id);
                return View(bookToDel);

            }
        }

        [HttpPost]
        public IActionResult Delete(Book book)
        {
            using (var db = new LibaryDbContext())
            {
                db.Remove(book);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}