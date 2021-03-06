﻿using System.Net.Sockets;
using System;
using System.ComponentModel.DataAnnotations;

namespace Breweries.Core
{
    public class Brewery
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Address Address { get; set; }
        public string Website { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public Province Province { get; set; }
    }
}
