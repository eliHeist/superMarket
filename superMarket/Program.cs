using System;

namespace superMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Item pen = new Item();
            pen.name = "Nice Clear GRIP Pen";
            pen.price = 500;
            Item notebook = new Item();
            notebook.name = "Leather Notebook";
            notebook.price = 5500;
            Item stylus = new Item();
            stylus.name = "Surface Stylet";
            stylus.price = 150000;

            Order order = new Order();
            order.AddItem(pen);
            order.AddItem(stylus);
            order.AddItem(notebook);

            order.Details();
        }
    }
}
