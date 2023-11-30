using AulaRazorPages.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AulaRazorPages.Pages.Movies
{
    public class DetailsModel(MoviesContext moviesContext) 
        : PageModel
    {
        public Movie Movie { get; private set; }

        public IActionResult OnGet([FromRoute] string permalink)
        {
            if (permalink == null)
            {
                return NotFound();
            }

            var movie = moviesContext.Movies
                .FirstOrDefault(x => x.Permalink == permalink);
            if (movie == null)
            {
                return NotFound();
            }

            this.Movie = movie;

            return Page();
        }
    }
}
