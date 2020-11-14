using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Breweries.Core;
using Breweries.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Breweries.Pages.Breweries
{
    public class EditModel : PageModel
    {
        private readonly IBreweriesService breweriesService;
        private readonly IHtmlHelper htmlHelper;

        [BindProperty]
        public Brewery Brewery { get; set; }
        public IEnumerable<SelectListItem> Provinces { get; set; }

        public EditModel(IBreweriesService breweriesService,
            IHtmlHelper htmlHelper)
        {
            this.breweriesService = breweriesService;
            this.htmlHelper = htmlHelper;
        }
        public IActionResult OnGet(int? breweryId)
        {
            Provinces = htmlHelper.GetEnumSelectList<Province>();

            if (breweryId.HasValue)
                Brewery = breweriesService.GetBreweryById(breweryId.Value);
            else 
                Brewery = new Brewery();

            if (Brewery == null)
                return RedirectToPage("./NotFound");
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Provinces = htmlHelper.GetEnumSelectList<Province>(); 
                return Page();
            }
            if (Brewery.Id > 0)
            {
                breweriesService.Update(Brewery);
                TempData["Message"] = "Brewery saved";
            }
            else 
            {
                breweriesService.Add(Brewery);
                TempData["Message"] = "Brewery added";               
            }
            
            breweriesService.Save();
            return RedirectToPage("./Detail", new { breweryId = Brewery.Id });

        }
    }
}