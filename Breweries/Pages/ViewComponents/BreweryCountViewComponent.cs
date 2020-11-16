using Microsoft.AspNetCore.Mvc;
using Breweries.Data;

namespace Breweries.Pages.ViewComponents
{
    public class BreweryCountViewComponent : ViewComponent
    {
        private readonly IBreweriesService breweryService;

        public BreweryCountViewComponent(IBreweriesService breweryService)
        {
            this.breweryService = breweryService;
        }

        public IViewComponentResult Invoke()
        {
            var count = breweryService.GetCountOfBreweries();
            return View(count);
        }
    }
}