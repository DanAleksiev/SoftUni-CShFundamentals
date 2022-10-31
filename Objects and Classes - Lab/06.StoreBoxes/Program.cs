using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Xml.Linq;

namespace _06.StoreBoxes
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input = null;
            List<Box> receive = new List<Box>();
            while ((input = Console.ReadLine()) != "end")
                {
                List<string> list = input
                    .Split()
                    .ToList();

                string serialNumber = list[0];
                string itemName = list[1];
                int itemQuantity = int.Parse(list[2]);
                decimal itemPrice = decimal.Parse(list[3]);

                Item item = new Item(itemName, itemPrice);
                Box inStock = new Box(serialNumber, item, itemQuantity);
                receive.Add(inStock);
                }
            foreach (var box in receive.OrderByDescending(x => x.PriceForBox))
                {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.ItemName} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:f2}");
                }
            }
        }
    public class Item
        {
        public Item(string itemName, decimal price)
            {
            ItemName = itemName;
            Price = price;
            }

        public string ItemName { get; set; }
        public decimal Price { get; set; }
        }
    public class Box
        {
        public Box(string serialNumber, Item item, int itemQuantity)
            {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;           
            }

        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForBox
            {
            get
                {
                return ItemQuantity * Item.Price;
                }
            }
        }
    }
