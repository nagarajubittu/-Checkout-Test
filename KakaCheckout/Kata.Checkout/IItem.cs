namespace Kata.Checkout
{
    public interface IItem
    {
        char ItemSku { get; set; }
        decimal Price { get; set; }
    }
}