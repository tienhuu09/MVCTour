using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCTour.Models;

namespace MVCTour.ViewComponents
{
    public class PlaceNavigation : ViewComponent
    {
        private ITourRepository repository;
        public PlaceNavigation(ITourRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedPlace = RouteData?.Values["place"];
            return View(repository.Nexts
            .Select(x => x.Place)
            .Distinct()
            .OrderBy(x => x));
        }
    }
}