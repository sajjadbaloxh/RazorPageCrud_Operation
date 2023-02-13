using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageMoviee.Data;
using RazorPageMoviee.Model;

namespace RazorPageMoviee.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPageMoviee.Data.RazorPageMovieeContext _context;

        public IndexModel(RazorPageMoviee.Data.RazorPageMovieeContext context)
        {
            _context = context;
        }

        public IList<Moviee> Moviee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Moviee != null)
            {
                Moviee = await _context.Moviee.ToListAsync();
            }
        }
    }
}
