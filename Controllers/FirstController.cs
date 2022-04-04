using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;

namespace MVCTour.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string HovaTen, int Tuoi = 1)
        {
            ViewData["Greeting"] = "Chao ban, toi la " + HovaTen + ". Tuoi cua toi la " + Tuoi.ToString() + ". Toi co the giup duoc gi cho ban ?";
            return View();
        }
    }
}
