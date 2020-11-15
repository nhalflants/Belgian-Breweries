using Breweries.Core;
using Microsoft.EntityFrameworkCore;

namespace Breweries.Data
{
    public class BreweriesDbContext : DbContext
    {
        public BreweriesDbContext(DbContextOptions<BreweriesDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<Brewery> Breweries { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}