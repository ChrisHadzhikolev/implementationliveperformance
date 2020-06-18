using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceImplementation
{
    public class Food:Item
    {
        public Food(string name, double price, string itemCode, int amount) : base(name, price, itemCode, amount)
        {
        }
    }
}
