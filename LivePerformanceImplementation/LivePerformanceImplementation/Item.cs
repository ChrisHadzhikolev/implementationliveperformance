using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceImplementation
{
    public abstract class Item
    {
        public string Name { get; }
        public double Price { get; }
        public string ItemCode { get; }
        public int Amount { get; }

        protected Item(string name, double price, string itemCode, int amount)
        {
            Name = name;
            Price = price;
            ItemCode = itemCode;
            Amount = amount;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
