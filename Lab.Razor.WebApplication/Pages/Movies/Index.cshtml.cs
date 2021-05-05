using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab.Razor.WebApplication.Data;
using Lab.Razor.WebApplication.Models;

namespace Lab.Razor.WebApplication.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Lab.Razor.WebApplication.Data.LabRazorWebApplicationContext _context;

        public IndexModel(Lab.Razor.WebApplication.Data.LabRazorWebApplicationContext context)
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
