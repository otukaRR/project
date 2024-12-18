using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VRPO5;

namespace VRPO5
{
    public class Administrator
    {
        public string Name { get; private set; }

        public Administrator(string name)
        {
            Name = name;
        }

        public void ConfirmOrder(Order order)
        {
            order.ConfirmOrder();
        }

        public void SendToKitchen(Order order)
        {
            Kitchen.PrepareOrder(order);
            Console.WriteLine("Заказ отправлен на кухню.");
        }

        public Bill CreateBill(Order order)
        {
            return new Bill(order.TotalAmount);
        }

        public void AddItemToMenu(Menu menu, Item item)
        {
            menu.AddItem(item);
            Console.WriteLine($"Пункт меню '{item.Name}' добавлен.");
        }
    }

}

