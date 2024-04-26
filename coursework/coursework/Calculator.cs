using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework
{

    public struct Item
    {
        public int Id;
        public string Name;
        public int Price;
    }


    public struct Cart
    {
        public int userId;
        public Dictionary<Item, int> items;
    }



    public class Calculator
    {
        public void AddToCart(Cart cart, Item item)
        {
            Dictionary<Item, int> items = cart.items;

            if (items[item] != 0){
                items[item] += 1;

            }
            else
            {
                items[item] = 1;
            }
        }

        public void RemoveFromCart(Cart cart, Item item)
        {
            cart.items[item] = 0;
        }

        public void Clear(Cart cart)
        {
            foreach (var item in cart.items)
            {
                cart.items[item.Key] = 0;
            }
        }


        public int getSum(Cart cart)
        {

            return cart.items.Values.Sum();
        }


    }

    
}
