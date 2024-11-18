using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_management_system
{
    internal class main
    {
        static void Main()
        {
           Restaurant restaurant = new Restaurant();
            int option;
            do
            {
                Console.WriteLine("________________________________________________________________");
                Console.WriteLine("Welcome to Sahyadri Restaurant...");
                Console.WriteLine("1.Display Menu..");
                Console.WriteLine("2.Place Order");
                Console.WriteLine("3.View Order");
                Console.WriteLine("4.Bill");
                Console.WriteLine("5.Exit");
                Console.WriteLine("________________________________________________________________");
                Console.Write("Enter option:");
                option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        restaurant.DisplayMenu();   
                        break;
                    case 2:
                        restaurant.PlaceOrder();
                        break;
                    case 3:
                        restaurant.ViewOrder();
                        break;
                    case 4:
                        restaurant.billOfOrder();
                        break;
                    default:
                        Console.WriteLine("Enter valid Option...");
                        break;
                }
            } while (option<5);
        }
    }
}
