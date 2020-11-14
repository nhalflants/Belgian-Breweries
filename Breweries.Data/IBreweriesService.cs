using System.Collections.Generic;
using System;
using Breweries.Core;

namespace Breweries.Data
{
    public interface IBreweriesService
    {
        IEnumerable<Brewery> GetBreweries();
        IEnumerable<Brewery> GetBreweriesByName(string name);
    }
}
