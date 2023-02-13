using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPageMoviee.Model;

namespace RazorPageMoviee.Data
{
    public class RazorPageMovieeContext : DbContext
    {
        public RazorPageMovieeContext (DbContextOptions<RazorPageMovieeContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPageMoviee.Model.Moviee> Moviee { get; set; } = default!;
    }
}
