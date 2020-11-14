using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Breweries.Data;
using Breweries.Core;

namespace Breweries.Pages.Breweries
{
    public class ListModel : PageModel
    {
        public string Message { get; set; }
        public IEnumerable<Brewery> Breweries { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }
        public readonly IConfiguration configuration;
        private readonly IBreweriesService breweries;

        public ListModel(IConfiguration configuration, IBreweriesService breweries)
        {
            this.configuration = configuration;
            this.breweries = breweries;
        }
        public void OnGet()
        {
            Message = configuration["Message"];
            Breweries = breweries.GetBreweriesByName(SearchTerm);
        }
    }
}