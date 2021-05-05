using Lab.Razor.WebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab.Razor.WebApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IEnumerable<TestUser> TestUsers;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            TestUsers = new List<TestUser>
            { 
                new TestUser { FirstName = "T1", LastName = "T2" },
                new TestUser { FirstName = "T1", LastName = "T2" },
                new TestUser { FirstName = "T1", LastName = "T2" },
                new TestUser { FirstName = "T1", LastName = "T2" },
                new TestUser { FirstName = "T1", LastName = "T2" },
                new TestUser { FirstName = "T1", LastName = "T2" },
                new TestUser { FirstName = "T1", LastName = "T2" }

            };
        }

       
    }
}
