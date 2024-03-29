﻿using Lab.Razor.WebApplication.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

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

        public void OnGet(int? id)
        {
            var users = new List<TestUser>
            {
                new TestUser { FirstName = "T1", LastName = "T2",Level=2 },
                new TestUser { FirstName = "T1", LastName = "T2",Level=2 },
                new TestUser { FirstName = "T1", LastName = "T2",Level=2 },
                new TestUser { FirstName = "T3", LastName = "T3", Level = 3 },
                new TestUser { FirstName = "T3", LastName = "T3", Level = 3 },
                new TestUser { FirstName = "T4", LastName = "T4",Level = 4 },
                new TestUser { FirstName = "T5", LastName = "T5" , Level = 5},
                new TestUser { FirstName = "T6", LastName = "T6", Level = 6 },
                new TestUser { FirstName = "T7", LastName = "T7", Level = 7 },
                new TestUser { FirstName = "T8", LastName = "T8", Level = 8}
            };
            if (id == null)
            {
                TestUsers = users.Take(1); ;
            }
            else
            {
                TestUsers = users.Take((int)id);
            }
        }
    }
}