using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Breweries.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Breweries.Pages.Breweries
{
    public class DetailModel : PageModel
    {
        public Brewery Brewery { get; set; }
        public void OnGet(int breweryId)
        {
            Brewery = new Brewery();
        }
    }
}