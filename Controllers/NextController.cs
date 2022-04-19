using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCTour.Models;
using MVCTour.Models.ViewModels;

namespace MVCTour.Controllers
{
    public class NextController : Controller
    {
        private ITourRepository repository;
        public int PageSize = 4;
        public NextController(ITourRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index(string place, int Page = 1)
         => View(new TourListViewModel
         {
             Nexts = repository.Nexts
         .Where(p => place == null || p.Place == place)
         .OrderBy(p => p.Id)
         .Skip((Page - 1) * PageSize)
         .Take(PageSize),
             PagingInfo = new PagingInfo
             {
                 CurrentPage = Page,
                 ItemsPerPage = PageSize,
                 TotalItems = place == null ?
         repository.Nexts.Count() :
         repository.Nexts.Where(e =>
         e.Place == place).Count()
             },
             CurrentPlace = place
         });
    }
}