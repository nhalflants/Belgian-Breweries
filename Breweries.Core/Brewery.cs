using System.Net.Sockets;
using System;
using System.ComponentModel.DataAnnotations;

namespace Breweries.Core
{
    public class Brewery
    {
        public int Id { get; set; }
        [Required, StringLength(3)]
        public string Name { get; set; }
        public Address Address { get; set; }
        public string Website { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public Province Province { get; set; }
    }
}
