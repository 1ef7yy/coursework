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

        public Cart Init(Item[] initItems)
        {
            foreach (var item in initItems)
            {
                items[item] = 0;
            }

            return this;
        }


        public void Add(Item item)
        {

            if (items[item] != 0)
            {
                items[item] += 1;
            }
            else
            {
                items[item] = 1;
            }
        }


        public void Remove(Item item)
        {
            items[item] = 0;
        }


        public void Clear()
        {
            foreach (var item in items)
            {
                items[item.Key] = 0;
            }
        }



        public int getSum()
        {
            return items.Values.Sum();
        }
    }



    public class Calculator
    {






    }


}
