using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab.Web101.Models
{
    public class CountryViewModel
    {
        //public string Country { get; set; }

        //public List<SelectListItem> Countries { get; } = new List<SelectListItem>
        //{
        //    new SelectListItem { Value = "MX", Text = "Mexico" },
        //    new SelectListItem { Value = "CA", Text = "Canada" },
        //    new SelectListItem { Value = "US", Text = "USA"  },
        //};
        public IEnumerable<string> CountryCodes { get; set; }

        public List<SelectListItem> Countries { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "MX", Text = "Mexico" },
            new SelectListItem { Value = "CA", Text = "Canada" },
            new SelectListItem { Value = "US", Text = "USA"    },
            new SelectListItem { Value = "FR", Text = "France" },
            new SelectListItem { Value = "ES", Text = "Spain"  },
            new SelectListItem { Value = "DE", Text = "Germany"}
         };
    }
}
