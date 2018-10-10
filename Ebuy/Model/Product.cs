using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebuy.Model
{
    public class Product
    {
        private Guid id;
        private decimal price;
        private string name;

        public Guid Id { get => id; set => id = value; }
        public decimal Price { get => price; set => price = value; }
        public string Name { get => name; set => name = value; }
        public ProductType Type { get; set; }
    }
}
