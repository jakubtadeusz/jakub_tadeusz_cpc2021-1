using JakubTadeuszLab4ZadDom.Database;
using JakubTadeuszLab4ZadDom.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JakubTadeuszLab4ZadDom.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Repository repository;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            repository = new Repository();
        }

        /// <summary>
        /// Show Index view with 10 latests albums
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View(repository.GetLatestAlbums(10));
        }

        /// <summary>
        /// Returns album view
        /// </summary>
        /// <param name="albumName"></param>
        /// <returns></returns>
        public IActionResult GetAlbum(string albumName)
        {
            ViewBag.Songs = repository.GetSongs(albumName);
            return View(repository.GetAlbum(albumName));
        }

        public IActionResult GetBand(string bandName)
        {
            ViewBag.Albums = repository.GetAlbums(bandName);
            return View(repository.GetBand(bandName));
        }

        /// <summary>
        /// Adds album to cart and redirect to the cart page
        /// </summary>
        /// <param name="albumName"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Cart(string albumName)
        {
            List<AlbumViewModel> cart = (List<AlbumViewModel>)TempData["cart"];
            if(cart == null)
            {
                cart = new List<AlbumViewModel>();
            }

            cart.Add((AlbumViewModel)repository.GetAlbum(albumName));
            TempData["cart"] = cart;
            return View(repository.GetAlbum(albumName));
        }

        /// <summary>
        /// Redirect to the cart page
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Cart()
        {
            List<AlbumViewModel> cart = (List<AlbumViewModel>)TempData["cart"];
            if (cart == null)
            {
                cart = new List<AlbumViewModel>();
            }
            return View();
        }

        /// <summary>
        /// Redirect to the view where user can summarize transaction
        /// </summary>
        /// <param name="albumName"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Finalize(string albumName)
        {
            AlbumViewModel album = (AlbumViewModel)repository.GetAlbum(albumName);
            Random random = new Random();
            InvoiceData invoice = new InvoiceData
            {
                Id = random.Next(0, 10000),
                Name = "",
                Surname = "",
                Email = "@example.com",
                PhoneNumber = 0,
                Value = album.Price
            };
            return View(invoice);
        }   
        
        /// <summary>
        /// Returns information about the finalized transaction
        /// </summary>
        /// <param name="invoice"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Finalize(InvoiceData invoice)
        {
            ViewBag.Invoice = invoice;
            return View("Invoice");
        }        
        
        /// <summary>
        /// Returns view to the page where user can request new album to add
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult SubmitAlbum()
        {
            return View();
        }

        /// <summary>
        /// Handles submit new album request
        /// </summary>
        /// <param name="album"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult SubmitAlbum(AlbumViewModel album)
        {
            ViewBag.Album = album;
            return View("FinishAlbumSubmit");
        }

        /// <summary>
        /// Returns view with greeting that new album request was received
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult SubmitAlbumGreeting(ContactDataViewModel contact)
        {
            return View(contact);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
