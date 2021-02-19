namespace Kata.Checkout
{
    public interface IPromotionCalculator
    {
        decimal Calculate(char itemSku, int quantity, decimal price);
    }
}