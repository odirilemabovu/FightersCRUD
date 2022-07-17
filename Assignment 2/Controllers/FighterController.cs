using Assignment_2.Data;
using Assignment_2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_2.Controllers
{
    public class FighterController : Controller
    {
        private readonly ApplicationDBContext _db;

        public FighterController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Fighters()
        {
            IEnumerable<Fighters> objList = _db.Fighters;
            return View(objList);
        }

        public IActionResult AddFighter()
        {
            return View();
        }

        public IActionResult AddBender()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Fighters obj)
        {
            if (ModelState.IsValid)//Checks to see if all the required fields have been met.
            {
                _db.Fighters.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Fighters");
            }
            return View(obj);

        }

        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Fighters.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Fighters obj)
        {
            _db.Fighters.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Fighters");
        }
    }
}
