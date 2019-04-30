namespace CompetitorEntries.Controllers
{
    using CompetitorEntries.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;

    public class CompetitorController : Controller
    {
        private readonly CompetitorEntriesDbContext context;

        public CompetitorController(CompetitorEntriesDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            using (var db = new CompetitorEntriesDbContext())
            {
                var competitor = db.Competitors.ToList();
                return View(competitor);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Competitor competitor)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            using (var db = new CompetitorEntriesDbContext())
            {
                db.Add(competitor);
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
            using (var db = new CompetitorEntriesDbContext())
            {
                var competitor = db.Competitors.Find(id);
                return View(competitor);
            }
        }

        [HttpPost]
        public IActionResult Edit(Competitor competitor)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            using (var db = new CompetitorEntriesDbContext())
            {
                db.Update(competitor);
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
            using (var db = new CompetitorEntriesDbContext())
            {
                var competitor = db.Competitors.Find(id);
                return View(competitor);
            }
        }

        [HttpPost]
        public IActionResult Delete(Competitor competitor)
        {
            using (var db = new CompetitorEntriesDbContext())
            {
                db.Remove(competitor);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}