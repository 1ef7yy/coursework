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
    public class Calculator
    {
        public List<Item> cart;


        public void AddToCart(Item item)
        {
            cart.Add(item);
        }

        public void RemoveFromCart(Item item)
        {
            cart.Remove(item);
        }

        public void Clear()
        {
            cart.Clear();
        }


        public int getSum()
        {
            int sum = 0;


            foreach (var item in cart)
            {
                sum += item.Price;
            }

            return sum;
        }


    }

    
}
