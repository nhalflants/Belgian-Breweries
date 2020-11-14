using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Breweries.Core;
using Breweries.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Breweries.Pages.Breweries
{
    public class DetailModel : PageModel
    {
        private readonly IBreweriesService breweriesService;

        public Brewery Brewery { get; set; }

        public DetailModel(IBreweriesService breweriesService)
        {
            this.breweriesService = breweriesService;
        }
        public IActionResult OnGet(int breweryId)
        {
            Brewery = breweriesService.GetBreweryById(breweryId);
            if (Brewery == null) 
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}