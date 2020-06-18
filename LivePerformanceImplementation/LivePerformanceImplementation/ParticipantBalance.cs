using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceImplementation
{
    public class ParticipantBalance
    {
        public Dictionary<Item, int> PurchasedItems { get; set; }
        public double Costs
            {
            get 
            {
                double price = 0;
                foreach (var item in PurchasedItems.Keys)
                {
                    price += PurchasedItems[item] * item.Price;
                }
                return price;
            }
            
            }

        public ParticipantBalance()
        {
            PurchasedItems = new Dictionary<Item, int>();
        }
    }
}
