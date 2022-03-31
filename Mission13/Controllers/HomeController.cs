using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission13.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission13.Controllers
{
    public class HomeController : Controller
    {
        private IBowlersRepository _repo { get; set; }
        public HomeController(IBowlersRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
            var blah = _repo.Bowlers.ToList();
            return View(blah);
        }

        public IActionResult Create(Bowler aab)
        {
            //_repo.AddBowler(aab);
            return View("AddBowlerForm");
        }

        public IActionResult AddBowler(Bowler ab)
        {
            _repo.AddBowler(ab);
            return RedirectToAction("Index", ab);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var application = _repo.Bowlers.Single(x => x.BowlerID == id);
            return View("AddBowlerForm", application);
        }

        [HttpPost]
        public IActionResult Edit(Bowler ab)
        {
            _repo.SaveChanges(ab);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int bid)
        {
            var bowler = _repo.Bowlers.Single(x => x.BowlerID == bid);
            return View(bowler);
        }

        [HttpPost]
        public IActionResult Delete(Bowler del)
        {
            _repo.DeleteBowler(del);

            return RedirectToAction("Index");
        }
    }
}
