using JakubTadeuszLab5ZadDom.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JakubTadeuszLab5ZadDom.Controllers
{
    /// <summary>
    /// Controller that handles requests about witchers
    /// </summary>
    public class WitchersController : Controller
    {
        private readonly DatabaseContext _context;

        public WitchersController(DatabaseContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Returns all the witchers
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {

            return View(_context.WitcherSchools.Include(witcherSchool=>witcherSchool.Witchers).ToList());
        }

        /// <summary>
        /// Allow to create the witcher school
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult CreateSchool()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSchool(WitcherSchool witcherSchool)
        {
            _context.WitcherSchools.Add(witcherSchool);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }        
        
        /// <summary>
        /// Allow to create the new Witcher
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult CreateWitcher(int id)
        {
            Witcher witcher = new Witcher { SchoolId = id };
            return View(witcher);
        }

        [HttpPost]
        public IActionResult CreateWitcher(Witcher witcher)
        {
            witcher.Id = 0;
            _context.Witchers.Add(witcher);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Return view with the witcher school info
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult WitcherSchool(int id)
        {
            WitcherSchool witcherSchool = _context.WitcherSchools.Include(school => school.Witchers).FirstOrDefault(school => school.Id.Equals(id));
            if(witcherSchool == null)
            {
                return NotFound();
            }
            return View(witcherSchool);
        }
    }
}
