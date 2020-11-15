using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Breweries.Core
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }
        [ForeignKey("BreweryId")]
        public Brewery Brewery { get; set; }
        public int BreweryId { get; set; }
    }
}