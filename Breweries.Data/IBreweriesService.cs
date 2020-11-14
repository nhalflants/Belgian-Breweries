using System.Collections.Generic;
using System;
using Breweries.Core;

namespace Breweries.Data
{
    public interface IBreweriesService
    {
        IEnumerable<Brewery> GetBreweries();
        IEnumerable<Brewery> GetBreweriesByName(string name);
        Brewery GetBreweryById(int id);
        Brewery Update(Brewery brewery);
        int Save();
    }
}
