using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AZDONaPratica.Api.Models
{
    public class Product
    {
        public Product(string name, string image, decimal amount, string description)
        {
            Id = Guid.NewGuid();
            Name = name;
            Amount = amount;
            Description = description;
            Image = image;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
