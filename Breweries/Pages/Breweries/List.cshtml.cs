using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Breweries.Data;
using Breweries.Core;
using Microsoft.Extensions.Logging;

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
        private readonly ILogger<ListModel> logger;

        public ListModel(IConfiguration configuration, 
            IBreweriesService breweries,
            ILogger<ListModel> logger)
        {
            this.configuration = configuration;
            this.breweries = breweries;
            this.logger = logger;
        }
        public void OnGet()
        {
            logger.LogError("Executing ListModel");
            Message = configuration["Message"];
            Breweries = breweries.GetBreweriesByName(SearchTerm);
        }
    }
}