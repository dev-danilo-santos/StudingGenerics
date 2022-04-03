using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCodeAndContains.Entities
{
    internal class Product
    {
        public String Nome { get; set; }
        public double Price { get; set; }

        public Product(string nome, double price)
        {
            Nome = nome;
            Price = price;
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Product))
            {
                throw new ArgumentException("The object not is a product.");
            }
            Product other = (Product)obj;
            return Nome.Equals(other.Nome) && Price.Equals(other.Price);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, Price);
        }
    }
}
