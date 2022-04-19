using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTour.Models.ViewModels
{
    public class TourListViewModel
    {
        public IEnumerable<Tour> Nexts { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentPlace { get; set; }

    }
}
