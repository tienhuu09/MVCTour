using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCTour.Models;

namespace BooksStore.ViewComponents
{
    public class GenreNavigation : ViewComponent
    {
        private ITourRepository repository;
        public GenreNavigation(ITourRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedGenre = RouteData?.Values["place"];
            return View(repository.Nexts
            .Select(x => x.Place)
            .Distinct()
            .OrderBy(x => x));
        }
    }
}