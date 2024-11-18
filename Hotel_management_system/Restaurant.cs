using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_management_system
{
    internal class Restaurant
    {
        private List<Menu> menu = new List<Menu>();
        private List<OrderItem> orderitem = new List<OrderItem>();

        public void ListOfItems()
        {

            //Console.WriteLine("__________________________________________________");
            menu.Add(new Menu(1, "Akha masur", 150));
            menu.Add(new Menu(2, "bhakari", 20));
            menu.Add(new Menu(3, "chapati", 10));
            menu.Add(new Menu(4, "Dal Tadaka", 110));
            menu.Add(new Menu(5, "Masur", 90));
        }

        public void DisplayMenu()
        {
            try
            {
                ListOfItems();
                foreach (var items in menu)
                {
                    Console.WriteLine(items);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            
        }

        public void PlaceOrder()
        {
            try
            {
                Console.Write("Enter the item number you want to order:");
                if (int.TryParse(Console.ReadLine(), out int Id))
                {
                    Menu SelectItem = menu.Find(m => m.Id == Id);

                    if (SelectItem != null)
                    {
                        Console.Write("Enter The Quantity:");
                        if (int.TryParse(Console.ReadLine(), out int quantity))
                        {
                            orderitem.Add(new OrderItem(SelectItem, quantity));
                            Console.WriteLine($"'{SelectItem.Name}' is added to your order");
                        }
                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void ViewOrder()
        {
            try
            {
                if (orderitem.Count > 0)
                {
                    Console.WriteLine("--------------------------------Your Order----------------------------------");
                    foreach (var items in orderitem)
                    {
                         Console.WriteLine(items);
                    }
                }
                else
                {
                    Console.WriteLine("Order not yet placed...........");
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
           
        }

        public void billOfOrder()
        {
            try
            {
                Console.WriteLine("Your order details:");
                decimal totalBill = 0;
                foreach (var item in orderitem)
                {
                    Console.WriteLine($"{item}:Amount={item.getTotalPrice()}");
                    totalBill = totalBill + item.getTotalPrice();
                }
                Console.WriteLine("Total Amount :"+ totalBill);
                Console.WriteLine("Thank you for your order, please proceed to your payment.......");
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
