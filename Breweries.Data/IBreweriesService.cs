﻿using System.Collections.Generic;
using System;
using Breweries.Core;

namespace Breweries.Data
{
    public interface IBreweriesService
    {
        IEnumerable<Brewery> GetBreweries();
        IEnumerable<Brewery> GetBreweriesByName(string name);
        Brewery GetBreweryById(int id);
        Brewery Add(Brewery brewery);
        Brewery Update(Brewery brewery);
        Brewery Delete(int breweryId);
        int Save();
        int GetCountOfBreweries();
    }
}
