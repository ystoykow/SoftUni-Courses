using Microsoft.AspNetCore.Mvc;
using WildlifeRefuge.Models;
using System.Linq;

namespace WildlifeRefuge.Controllers
{
    public class AnimalController : Controller
    {
        private readonly WildlifeRefugeDbContext context;

        public AnimalController(WildlifeRefugeDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            using (var db = new WildlifeRefugeDbContext())
            {
                var animals = db.Animals.ToList();

                return View(animals);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Animal animal)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            using (var db = new WildlifeRefugeDbContext())
            {
                db.Add(animal);
                db.SaveChanges();

            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            using (var db = new WildlifeRefugeDbContext())
            {
                var animal = db.Animals.Find(id);
                return View(animal);
            }
        }

        [HttpPost]
        public IActionResult Edit(Animal animal)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            using (var db = new WildlifeRefugeDbContext())
            {
                db.Update(animal);
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
            using (var db = new WildlifeRefugeDbContext())
            {
                var animal = db.Animals.Find(id);
                return View(animal);
            }
        }

        [HttpPost]
        public IActionResult Delete(Animal animal)
        {
            using (var db = new WildlifeRefugeDbContext())
            {
                db.Remove(animal);
                db.SaveChanges();

            }
            return RedirectToAction("Index");
        }
    }
}