using System;
using System.Collections.Generic;
using System.Text;

namespace superMarket
{
    class Order
    {
        Item[] items = { };
        int no = 0;

        public void AddItem(Item item_to_add)
        {
            Array.Resize(ref items, items.Length + 1);
            int new_index = items.Length - 1;
            items[new_index] = item_to_add;
            Console.WriteLine("Added: " + item_to_add.name + "\n");
        }

        public void Details()
        {
            int item_count = items.Length;
            double total_price = 0;

            // loop to calculate total price
            foreach (Item item in items)
            {
                no++;
                total_price += item.price;
                Console.WriteLine(no + ". " + item.name + "     (Shs. " + item.price + ") \n");
            }

            Console.WriteLine("Total number of items: " + items.Length);
            Console.WriteLine("Total ammount:   Shs. " + total_price);
        }
    }
}
