using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPageMoviee.Data;
using RazorPageMoviee.Model;

namespace RazorPageMoviee.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly RazorPageMoviee.Data.RazorPageMovieeContext _context;

        public CreateModel(RazorPageMoviee.Data.RazorPageMovieeContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Moviee Moviee { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Moviee == null || Moviee == null)
            {
                return Page();
            }

            _context.Moviee.Add(Moviee);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
