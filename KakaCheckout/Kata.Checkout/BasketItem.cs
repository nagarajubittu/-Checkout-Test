namespace Kata.Checkout
{
    public class BasketItem : IBasketItem
    {
        public char ItemSku { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; private set; }
        public void Calculate(IPromotionCalculator promotionCalculator)
        {
            TotalPrice = promotionCalculator.Calculate(ItemSku, Quantity, Price);
        }
    }
}