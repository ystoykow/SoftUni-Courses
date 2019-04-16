using BandRegister.Data;
using BandRegister.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BandRegister.Controllers
{
    public class BandController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new BandRegisterDbContext())
            {
                var band = db.Band.ToList();
                return View(band);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {


            return View();
        }

        [HttpPost]
        public IActionResult Create(Band band)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            using (var db = new BandRegisterDbContext())
            {
                db.Band.Add(band);
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
            using (var db = new BandRegisterDbContext())
            {
                var bandToEdit = db.Band.Find(id);
                return View(bandToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Band band)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");

            }
            using (var db = new BandRegisterDbContext())
            {
                db.Update(band);
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
            using (var db = new BandRegisterDbContext())
            {
                var bandToDel = db.Band.Find(id);
                return View(bandToDel);
            }
        }

        [HttpPost]
        public IActionResult Delete(Band band)
        {
            
            using (var db = new BandRegisterDbContext())
            {
                db.Remove(band);
                db.SaveChanges();
            }
                return RedirectToAction("Index");
        }
    }
}