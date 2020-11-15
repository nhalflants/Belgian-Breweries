using System.Collections.Generic;
using Breweries.Core;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Breweries.Data
{
    public class BreweriesService : IBreweriesService
    {
        private readonly BreweriesDbContext dbContext;

        public BreweriesService(BreweriesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Brewery Add(Brewery brewery)
        {
            dbContext.Add(brewery);
            return brewery;
        }

        public Brewery Delete(int breweryId)
        {
            var brewery = GetBreweryById(breweryId);
            if (brewery != null)
                dbContext.Breweries.Remove(brewery);
            return brewery;
        }

        public IEnumerable<Brewery> GetBreweries()
        {
            return dbContext.Breweries.AsEnumerable();
        }

        public IEnumerable<Brewery> GetBreweriesByName(string name)
        {
            var query = from b in dbContext.Breweries
                where string.IsNullOrEmpty(name) || b.Name.StartsWith(name)
                orderby b.Name
                select b;
            return query;
        }

        public Brewery GetBreweryById(int id)
        {
            return dbContext.Breweries.Find(id);
        }

        public int Save()
        {
            return dbContext.SaveChanges();
        }

        public Brewery Update(Brewery brewery)
        {
            var entity = dbContext.Breweries.Attach(brewery);
            entity.State = EntityState.Modified;
            return brewery;
        }
    }
}