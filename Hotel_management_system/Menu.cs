using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_management_system
{
    internal class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }

        public Menu(int id, string name, decimal price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }
        public override string ToString()
        {
            return $" {Id}:{Name}:{Price}";
        }
    }
}
