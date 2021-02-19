namespace Kata.Checkout
{
    public interface IBasketItem : IItem
    {
        int Quantity { get; set; }
        decimal TotalPrice { get; }
        void Calculate(IPromotionCalculator promotionCalculator);
    }
}