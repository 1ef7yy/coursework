namespace coursework
{

    public struct Item
    {
        public string Name;
        public int Price;
        public int Amount;
        
        public Item(string name, int price, int amount)
        {
            Name = name;
            Price = price;
            Amount = amount;

        }
    }

    


    public static class Cart
    {
        public static List<Item> items = new List<Item>();
        public static int sum = 0;

        public static Dictionary<string, int> Prices = new Dictionary<string, int>{

            { "beef", 1000},
            { "eggs", 150},
            {"oreshki", 250 },
            {"pear", 120 },
            {"water", 105 }

    };
    }



    public class Calculator
    {
        


        public int getSum()
        {
            Cart.sum = Cart.items.Sum(x => Convert.ToInt32(x.Price));
            return Cart.sum;
        }



    }


}
