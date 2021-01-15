using System;
using System.Collections.Generic;

#nullable disable

namespace BurgerApp.Models
{
    public partial class Order
    {
        public string OrderId { get; set; }
        public decimal? Salad { get; set; }
        public decimal? Cheese { get; set; }
        public decimal? Bacon { get; set; }
        public decimal? Meat { get; set; }
        public decimal? TotalPrice { get; set; }
    }
}
