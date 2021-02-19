using System;

namespace Kata.Checkout
{
    class Program
    {
        static void Main(string[] args)
        {
            IItemCollection itemCollection = new ItemCollection();
            IPromotionCalculator calculator = new PromotionCalculator();
            IBasket basket = new Basket(calculator);

            basket.AddItem(new BasketItem
            {
                ItemSku = 'A',
                Price = itemCollection.GetBySku('A').Price,
                Quantity = 1,
            });

            basket.AddItem(new BasketItem
            {
                ItemSku = 'B',
                Price = itemCollection.GetBySku('B').Price,
                Quantity = 7,
            });

            basket.AddItem(new BasketItem
            {
                ItemSku = 'C',
                Price = itemCollection.GetBySku('C').Price,
                Quantity = 1,
            });

            basket.AddItem(new BasketItem
            {
                ItemSku = 'D',
                Price = itemCollection.GetBySku('D').Price,
                Quantity = 7,
            });

            foreach (var basketItem in basket.Items)
            {
                Console.WriteLine($"{basketItem.ItemSku}: {basketItem.Price} X {basketItem.Quantity} = {basketItem.TotalPrice}");
            }

            Console.WriteLine($"Total Price: {basket.TotalPrice}");

            Console.ReadLine();
        }
    }
}
