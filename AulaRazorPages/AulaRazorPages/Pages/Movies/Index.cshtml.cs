using AulaRazorPages.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AulaRazorPages.Pages.Movies;

public class IndexModel(MoviesContext moviesContext)
    : PageModel
{
    public ICollection<Movie> Movies { get; private set; }

    public void OnGet()
    {
        Movies = moviesContext.Movies.ToList();
    }

    //public async Task OnGetAsync()
    //{
    //    Movies = await moviesContext.Movies.ToListAsync();
    //}
}
