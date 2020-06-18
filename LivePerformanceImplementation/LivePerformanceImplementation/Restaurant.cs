using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceImplementation
{
    public class Restaurant:Store
    {
        public Restaurant() 
        {
            Food f = new Food("Chocolate", 2.0, "1", 19);
            Food f1 = new Food("Muffin", 5.0, "2", 199);
            Food f2 = new Food("Spaghetti", 12.0, "3", 169);
            Food f3 = new Food("Berries", 10.0, "4", 179);
            Food f4 = new Food("Steak", 22.0, "5", 119);
            Drink d = new Drink("Vodka", 8.0, "6", 56, 50);
            Drink d1 = new Drink("Coke", 3.0, "6", 56, 500);
            Drink d2 = new Drink("Red Bull", 7.0, "6", 56, 330);
            Drink d3 = new Drink("Juice", 3.0, "6", 56, 330);
            Drink d4 = new Drink("Water", 1.5, "6", 56, 500);
            Items.Add(f, f.Amount);
            Items.Add(f1, f1.Amount);
            Items.Add(f2, f2.Amount);
            Items.Add(f3, f3.Amount);
            Items.Add(f4, f4.Amount);
            Items.Add(d, d.Amount);
            Items.Add(d1, d1.Amount);
            Items.Add(d2, d2.Amount);
            Items.Add(d3, d3.Amount);
            Items.Add(d4, d4.Amount);

        }
       
        public override Dictionary<Item, int> Items { get; set; }

        public override Dictionary<Item, int> Cart { get; set; }

        public override double Revenue { get; set; }

       
    }
}
