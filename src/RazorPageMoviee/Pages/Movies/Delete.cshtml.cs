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
    public class DeleteModel : PageModel
    {
        private readonly RazorPageMoviee.Data.RazorPageMovieeContext _context;

        public DeleteModel(RazorPageMoviee.Data.RazorPageMovieeContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Moviee Moviee { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Moviee == null)
            {
                return NotFound();
            }

            var moviee = await _context.Moviee.FirstOrDefaultAsync(m => m.Id == id);

            if (moviee == null)
            {
                return NotFound();
            }
            else 
            {
                Moviee = moviee;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Moviee == null)
            {
                return NotFound();
            }
            var moviee = await _context.Moviee.FindAsync(id);

            if (moviee != null)
            {
                Moviee = moviee;
                _context.Moviee.Remove(Moviee);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
