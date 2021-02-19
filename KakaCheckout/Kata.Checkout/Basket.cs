using System.Collections.Generic;

namespace Kata.Checkout
{
    public class Basket : IBasket
    {
        private readonly IPromotionCalculator _promotionCalculator;
        private readonly List<IBasketItem> _items;

        public Basket(IPromotionCalculator promotionCalculator)
        {
            _promotionCalculator = promotionCalculator;
            _items = new List<IBasketItem>();
            TotalPrice = decimal.Zero;
        }

        public int ItemsCount => _items.Count;
        public decimal TotalPrice { get; set; }

        public List<IBasketItem> Items => _items;
        public void AddItem(IBasketItem basketItem)
        {
            _items.Add(basketItem);
            basketItem.Calculate(_promotionCalculator);
            TotalPrice += basketItem.TotalPrice;
        }
    }
}