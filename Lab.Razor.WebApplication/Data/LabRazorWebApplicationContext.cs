using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab.Razor.WebApplication.Models;

namespace Lab.Razor.WebApplication.Data
{
    public class LabRazorWebApplicationContext : DbContext
    {
        public LabRazorWebApplicationContext (DbContextOptions<LabRazorWebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Lab.Razor.WebApplication.Models.Movie> Movie { get; set; }
    }
}
