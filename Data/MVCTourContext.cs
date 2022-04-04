using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCTour.Models;

namespace MVCTour.Data
{
    public class MVCTourContext : DbContext
    {
        public MVCTourContext()
        {

        }

        public MVCTourContext (DbContextOptions<MVCTourContext> options)
            : base(options)
        {
        }
        public DbSet<Tour> Tourss { get; set; }
        public DbSet<MVCTour.Models.Tour> Tour { get; set; }
    }
}
