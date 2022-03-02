using System;

namespace WDCheWei_task6
{
    using System;
    using System.Collections.Generic;

    public class Example
    {
        public static void Main()
        {
            var inventory = new Dictionary<string, int>()
            {
                ["hammer, ball pein"] = 18,
                ["hammer, cross pein"] = 5,
                ["screwdriver, Phillips #2"] = 14
            };

            Console.WriteLine($"Inventory on {DateTime.Now:d}");
            Console.WriteLine(" ");
            Console.WriteLine($"|{"Item",25}|{"Quantity",10}|");
            foreach (var item in inventory)
            Console.WriteLine($"|{item.Key,25}|{item.Value,10}|");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine($"[{DateTime.Now,-20:d}] Hour [{DateTime.Now,-10:HH}] [{1063.342,15:N2}] feet");
            //class Vegetable
            //{
            //    public Vegetable(string name) => Name = name;

            //    public string Name { get; }

            //    //public override string ToString() => Name;
            //}
            //class program
            //{
            //    public enum Unit { item, kilogram, gram, dozen };

            //    public static void Main()
            //    {
            //        var item = new Vegetable("eggplant");
            //        var date = DateTime.Now;
            //        var price = 1.99m;
            //        var unit = Unit.item;
            //        Console.WriteLine($"On {date:yyyy}, the price of {item} was {price:F3} per {unit}.");



            //    }
            //}
        }
    }
}
