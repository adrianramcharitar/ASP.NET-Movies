using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using UserStudyApplication.Data;

namespace UserStudyApplication.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly UserStudyApplication.Data.UserStudyApplicationContext _context;

        public IndexModel(UserStudyApplication.Data.UserStudyApplicationContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
