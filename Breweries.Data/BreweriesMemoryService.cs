using System.Collections.Generic;
using System.Linq;
using Breweries.Core;

namespace Breweries.Data
{
    public class BreweriesMemoryService : IBreweriesService
    {
        private readonly List<Brewery> breweries;

        public BreweriesMemoryService()
        {
            breweries = new List<Brewery>()
            {
                new Brewery {
                    Id = 1,
                    Name = "Huisbrouwerij Domus",
                    Website = "www.domusleuven.be",
                    Description = "In and around the year 1900 Belgium had over 4,000 breweries. Most of the beers brewed at that time were regional beers and some were served only in the local watering hole. Since September 1985 the Domus home brewery on Tiensestraat in Leuven has been brewing its own old-fashioned, delicious beers, without additives, in its small-scale brewery. A home brewery is defined as a small brewery which is directly related to a caf\u00e9 where beer lovers can taste the brews in the best possible conditions.",
                    ImageURL = "https://www.flickr.com/photos/visitflanders/7500919334/in/album-72157628088884326/",
                    Province = Province.VlaamsBrabant,
                    Address = new Address {
                        Street = "Tiensestraat",
                        Number = 8,
                        PostalCode = 3000,
                        City = "Leuven"
                    }
                },
                new Brewery {
                    Id = 2,
                    Name = "Geuzestekerij De Cam",
                    Website = "www.decam.be",
                    Description = "De Cam is a Gueuze brewery in Gooik (Brabant) which, in 1997, launched its first locally- blended Gueuze. The wort is sourced from various Lambic breweries (Boon, Girardin and Lindemans) and undergoes a spontaneous fermentation and ripening in Gooik. Lambic of various ages is then blended and the beer then ferments in the bottle for at least another year. After a visit to the Gueuze brewery visitors can enjoy a beer in the authentic people\u2019s caf\u00e9 across the road.",
                    ImageURL = "",                  
                    Province = Province.VlaamsBrabant,
                    Address = new Address {
                        Street = "Dorpsstraat",
                        Number = 67,
                        PostalCode = 1755,
                        City = "Gooik"
                    }
                }
            };
        }

        public IEnumerable<Brewery> GetBreweries()
        {
            return breweries;
        }

        public IEnumerable<Brewery> GetBreweriesByName(string name = null)
        {
            return from b in breweries
                where string.IsNullOrEmpty(name) || b.Name.StartsWith(name)
                orderby b.Name
                select b;
            // return breweries
            //     .Where(b => b.Name.StartsWith(name) || string.IsNullOrEmpty(name))
            //     .OrderBy(b => b.Name)
            //     .AsEnumerable();
        }

        public Brewery GetBreweryById(int id)
        {
            return breweries.SingleOrDefault(b => b.Id == id);
        }
    }
}