using System;

namespace Kata.Checkout
{
    public class PromotionCalculator : IPromotionCalculator
    {
        public decimal Calculate(char itemSku, int quantity, decimal price)
        {
            switch (itemSku)
            {
                case 'B':
                    var bq = quantity;
                    if (quantity % 3 != 0 && quantity > 3)
                    {
                        bq = quantity - 1;
                    }
                    return (quantity * price) - ((bq / 3) * 5);
                case 'D':
                    var dq = quantity;
                    if (quantity % 2 != 0 && quantity > 2)
                    {
                        dq = quantity - 1;
                    }
                    return (quantity * price) - (quantity / 2 * (2 * price * 25 / 100));
                default:
                    return quantity * price;
            }
        }
    }
}