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
    public class EditModel : PageModel
    {
        private readonly IBreweriesService breweriesService;
        public Brewery Brewery { get; set; }

        public EditModel(IBreweriesService breweriesService)
        {
            this.breweriesService = breweriesService;
        }
        public void OnGet()
        {

        }
    }
}