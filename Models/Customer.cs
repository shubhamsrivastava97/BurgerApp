using System;
using System.Collections.Generic;

#nullable disable

namespace BurgerApp.Models
{
    public partial class Customer
    {
        public string CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string Delivery { get; set; }
    }
}
