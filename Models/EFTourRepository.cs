using Microsoft.AspNetCore.Mvc;
using MVCTour.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTour.Models
{
    public class EFTourRepository : ITourRepository
    {
        private MVCTourContext context;
        public EFTourRepository(MVCTourContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Tour> Nexts => context.Nexts;
    }
}
