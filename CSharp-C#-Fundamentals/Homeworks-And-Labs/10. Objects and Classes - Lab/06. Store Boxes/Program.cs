using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            List<Item> items = new List<Item>();
            List<Box> boxes = new List<Box>();

            while (line != "end")
            {
                string[] command = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string serialNum = command[0];
                string name = command[1];
                int quant = int.Parse(command[2]);
                decimal singlePrice = decimal.Parse(command[3]);

                Item item = new Item();

                item.Name = name;
                item.Price = singlePrice;

                Box box = new Box();
                               
                box.SerialNum = serialNum;
                box.Item = name;
                box.ItemQuantity = quant;
                box.BoxPrice = quant*singlePrice;
                box.SinglePrice = singlePrice;

                items.Add(item);
                boxes.Add(box);

                line = Console.ReadLine();
            }
            foreach (Box box in boxes.OrderByDescending(n => n.BoxPrice))
            {
                Console.WriteLine(box.SerialNum);
                Console.WriteLine($"-- {box.Item} - ${box.Item:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.BoxPrice:f2}");
            }
        }   
    }
    class Item
    {       
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {
       
        public string SerialNum { get; set; }
        public string Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal BoxPrice { get; set; }
        public decimal SinglePrice { get; set; }
    }
}
