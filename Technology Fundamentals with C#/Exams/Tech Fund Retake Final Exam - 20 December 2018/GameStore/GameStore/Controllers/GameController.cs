using System;
using System.Collections.Generic;
using System.Linq;
using GameStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new GameStoreDbContext())
            {
                var games = db.Games.ToList();


                return View(games);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Game game)
        {
            using (var db = new GameStoreDbContext())
            {
                if (!ModelState.IsValid)
                {
                    return RedirectToAction("Index");
                }
                db.Add(game);
                db.SaveChanges();
                
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            using (var db = new GameStoreDbContext())
            {
                var editGame = db.Games.Find(id);
                return View(editGame);
            }
        }

        [HttpPost]
        public IActionResult Edit(Game game)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            using (var db = new GameStoreDbContext())
            {
                db.Games.Update(game);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            using (var db = new GameStoreDbContext())
            {
                var delGame = db.Games.Find(id);
                return View(delGame);
            }
        }

        [HttpPost]
        public IActionResult Delete(Game game)
        {
            using (var db = new GameStoreDbContext())
            {
                db.Games.Remove(game);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}