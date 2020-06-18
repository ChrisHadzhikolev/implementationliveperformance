using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformanceImplementation
{
    public abstract class Store
    {
        public abstract Dictionary<Item, int> Items{ get; set; }
        public abstract Dictionary<Item, int> Cart { get; set; }
        public abstract double Revenue { get; set; }


        protected Store()
        {
            Items = new Dictionary<Item, int>();
            Cart = new Dictionary<Item, int>();
        }

        public Item GetItemByName(string name) 
        {
            foreach (var item in Items.Keys)
            {
                if (item.Name == name) return item;
            }
            return null;
        }

        public bool AddItemToCart(Item item, int quantity) 
        {
            if (quantity < 1) throw new ArgumentException("Quantity should be at least 1");
            if (Items.ContainsKey(item))
            {
                if (Items[item] >= quantity)
                {
                    if (Cart.ContainsKey(item))
                    {
                        Cart[item] += quantity;
                        return true;
                    }
                    else
                    {
                        Cart.Add(item, quantity);
                        return true;
                    }
                }
                else
                {
                    throw new ArgumentException("Not enough items in stock");
                }
            }
            else
            {
                throw new ArgumentException("No Such Item");
            }
        }
        public bool RemoveItemFromCart(Item item, int quantity)
        {
            if (Cart.ContainsKey(item)) 
            {
                if (Cart[item] >= quantity)
                {
                    if (Cart[item] == quantity)
                    {
                        Cart.Remove(item);
                    }
                    else
                    {
                        Cart[item] -= quantity;
                    }
                    return true;
                }
                else
                {
                    throw new ArgumentException("requested quantity is bigger than quantity in card");
                }
            }
            else
            {
                throw new ArgumentException("no such item in cart");
            }
        }
        public void Purchase(Participant participant)
        {
            if (Cart.Count > 0) 
            {
                double price = 0;
                foreach (var item in Cart.Keys)
                {
                    price += Cart[item] * item.Price;
                    participant.Balance.PurchasedItems.Add(item, Cart[item]);
                }
                Cart.Clear();
                Revenue += price;
            }
            else
            {
                throw new ArgumentException("Empty Cart");
            }
        }


    }
}
