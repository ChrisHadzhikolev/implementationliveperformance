using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceImplementation
{
    public class Drink:Item
    {
        public int NumberOfMillilitres { get; }
        public Drink(string name, double price, string itemCode, int amount, int numberOfMillitres):base(name, price, itemCode, amount) 
        {
            NumberOfMillilitres = numberOfMillitres;
        }
    }
}
