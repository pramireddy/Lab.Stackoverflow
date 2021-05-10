using Lab.Razor.WebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab.Razor.WebApplication.ViewComponents
{
    public class RouteViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync(TestUser user)
        {
            var users = new List<TestUser>
            {
                new TestUser { FirstName = "T1", LastName = "T2",Level=2 },
                new TestUser { FirstName = "T1", LastName = "T2",Level=3 },
                new TestUser { FirstName = "T1", LastName = "T2",Level=2 },
                new TestUser { FirstName = "T3", LastName = "T3", Level = 3 },
                new TestUser { FirstName = "T3", LastName = "T3", Level = 3 },
                new TestUser { FirstName = "T4", LastName = "T4",Level = 4 },
                new TestUser { FirstName = "T5", LastName = "T5" , Level = 5},
                new TestUser { FirstName = "T6", LastName = "T6", Level = 6 },
                new TestUser { FirstName = "T7", LastName = "T7", Level = 7 },
                new TestUser { FirstName = "T8", LastName = "T8", Level = 8}
            };

            var result = users.Where(x => x.Level <= user.Level);
            return await Task.FromResult(View(result));
        }
    }
}
