using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorMovie.Data;
using RazorMovie.Models;

namespace RazorMovie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorMovie.Data.RazorMovieContext _context;

        public IndexModel(RazorMovie.Data.RazorMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movies { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        
        public SelectList Genres { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string MovieGenre { get; set; }

        public async Task OnGetAsync()
        {
            // Movies = await _context.Movies.ToListAsync();

            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Movies
                                            orderby m.Genre
                                            select m.Genre;

            var movies = from m in _context.Movies
                            select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(MovieGenre))
            {
                movies = movies.Where(x => x.Genre == MovieGenre);
            }

            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());

            Movies = await movies.ToListAsync();
        }
    }
}
