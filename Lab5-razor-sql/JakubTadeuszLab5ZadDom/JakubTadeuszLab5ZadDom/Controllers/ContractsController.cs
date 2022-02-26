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
    /// Controller that handle contracts
    /// </summary>
    public class ContractsController : Controller
    {
        private readonly DatabaseContext _context;

        public ContractsController(DatabaseContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Show all the active contracts
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View(_context.Contracts.Include(contract=>contract.Witcher).Where(contract=>contract.Status != ContractStatus.Completed).ToList());
        }       
        
        /// <summary>
        /// Return all the contracts, even finished
        /// </summary>
        /// <param name="showFinished"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Index(string showFinished)
        {
            if (showFinished != null)
            {
                return View(_context.Contracts.Include(contract => contract.Witcher).ToList());
            }
            return RedirectToAction(nameof(Index));
        }


        /// <summary>
        /// Return view to create the new contract
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult CreateContract()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateContract(Contract contract)
        {
            _context.Contracts.Add(contract);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }        
        
        /// <summary>
        /// Allow witcher to accept the contract
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult AcceptContract(int id)
        {
            ViewBag.Witchers = _context.Witchers.ToList();
            Contract contract = _context.Contracts.FirstOrDefault(contract => contract.Id.Equals(id));  
            contract.Status = ContractStatus.InProgress;
            return View(contract);
        }

        [HttpPost]
        public IActionResult AcceptContract(Contract contract)
        {
            _context.Contracts.Update(contract);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }        
        
        /// <summary>
        /// Allow to edit the contract
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult EditContract(int id)
        {
            ViewBag.Witchers = _context.Witchers.ToList();
            Contract contract = _context.Contracts.Include(contract=>contract.Witcher).FirstOrDefault(contract => contract.Id.Equals(id));
            return View(contract);
        }

        [HttpPost]
        public IActionResult EditContract(Contract contract)
        {
            _context.Contracts.Update(contract);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }        
        
        /// <summary>
        /// Allow to delete contract
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult DeleteContract(int id)
        {
            ViewBag.Witchers = _context.Witchers.ToList();
            Contract contract = _context.Contracts.FirstOrDefault(contract => contract.Id.Equals(id));
            contract.Status = ContractStatus.InProgress;
            return View(contract);
        }

        [HttpPost]
        public IActionResult DeleteContract(Contract contract)
        {
            _context.Contracts.Remove(contract);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
