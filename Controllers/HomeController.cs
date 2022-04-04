using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCTour.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using MVCTour.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace MVCTour.Controllers
{
    public class HomeController : Controller
    {
        private readonly MVCTourContext _context;

        public HomeController(MVCTourContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string tourPlace, string searchString)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> placeQuery = from b in _context.Tour
                                            orderby b.Place
                                            select b.Place;
            var tours = from b in _context.Tour
                        select b;
            if (!string.IsNullOrEmpty(searchString))
            {
                tours = tours.Where(s => s.NameTour!.Contains(searchString));
            }
            if (!string.IsNullOrEmpty(tourPlace))
            {
                tours = tours.Where(x => x.Place == tourPlace);
            }
            var TourPlaceVM = new TourPlaceViewModel
            {
                Places = new SelectList(await placeQuery.Distinct().ToListAsync()),
                Tours = await tours.ToListAsync()
            };
            return View(TourPlaceVM);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login(string Tour)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult List()
        {
            return View();
        }
    }
}
