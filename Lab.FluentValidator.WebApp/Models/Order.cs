using System.Collections.Generic;

namespace Lab.FluentValidator.WebApp.Models
{
    public class Order
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string CustomerEmail { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public IEnumerable<Product> Products { get; set; } = new List<Product>();
    }
}