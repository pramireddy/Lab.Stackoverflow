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

            return await Task.FromResult(View(user));
        }
    }
}
