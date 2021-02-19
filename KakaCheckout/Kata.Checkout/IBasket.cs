using System.Collections.Generic;

namespace Kata.Checkout
{
    public interface IBasket
    {
        int ItemsCount { get; }
        List<IBasketItem> Items { get; }
        decimal TotalPrice { get; set; }
        void AddItem(IBasketItem itemSku);
    }
}