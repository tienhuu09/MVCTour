using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
namespace MVCTour.Models
{
    public class TourPlaceViewModel
    {
        public List<Tour> Tours { get; set; }
        public SelectList Places { get; set; }
        public string TourPlace { get; set; }
        public string SearchString { get; set; }
    }
}