using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_management_system
{
    internal class OrderItem
    {
        Menu menu { get; set; }

        int Quantity { get; set; }

        public OrderItem(Menu menu,int Quantity)
        {
           this.menu = menu;
            this.Quantity = Quantity;
        }

        public decimal  getTotalPrice()
        {
            return menu.Price * Quantity;
        }

        // Method to display details of the OrderItem
        public override string ToString()
        {
            return $"{menu}:{Quantity}";
        }
       
    }
}
