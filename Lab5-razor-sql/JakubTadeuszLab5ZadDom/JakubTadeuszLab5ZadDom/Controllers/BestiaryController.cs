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
    /// Bestiary controller
    /// </summary>
    public class BestiaryController : Controller
    {
        private readonly DatabaseContext _context;

        public BestiaryController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.BeastTypes.ToList());
        }

        /// <summary>
        /// Allow to create new beast type
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult CreateType()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateType(BeastType beastType)
        {
            _context.BeastTypes.Add(beastType);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Return view with all the beasts, with beast types 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult BeastType(int id)
        {
            BeastType beastType = _context.BeastTypes.Include(beastType => beastType.Beasts).FirstOrDefault(beastType => beastType.Id.Equals(id));
            if(beastType == null)
            {
                return NotFound();
            }
            return View(beastType);
        }

        /// <summary>
        /// Return view with the beast summary
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Beast(int id)
        {
            Beast beast = _context.Beasts.Include(beast=>beast.Type).FirstOrDefault(beast => beast.Id.Equals(id));
            if (beast == null)
            {
                return NotFound();
            }
            return View(beast);
        }  
        
        /// <summary>
        /// Allow to add the new beast
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult CreateBeast(int id)
        {
            Beast beast = new Beast { TypeId = id };
            return View(beast);
        }
        [HttpPost]
        public IActionResult CreateBeast(Beast beast)
        {
            beast.Id = 0;
            _context.Beasts.Add(beast);
            _context.SaveChanges();
            return RedirectToAction(nameof(BeastType), new { id = beast.TypeId });
        }

    }
}
