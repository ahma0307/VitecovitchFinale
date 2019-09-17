using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VitecovitchFinale.Models
{
    public class VitecovitchFinaleContext : DbContext
    {
        public VitecovitchFinaleContext (DbContextOptions<VitecovitchFinaleContext> options)
            : base(options)
        {
        }

        public DbSet<VitecovitchFinale.Models.Customer> Customer { get; set; }
    }
}
