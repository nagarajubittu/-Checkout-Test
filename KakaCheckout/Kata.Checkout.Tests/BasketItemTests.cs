using Xunit;

namespace Kata.Checkout.Tests
{

    public class BasketItemTests
    {
        private readonly IPromotionCalculator _promotionCalculator = new PromotionCalculator();


        [Theory]
        [InlineData('A', 10, 2, 20)]
        [InlineData('B', 15, 3, 40)]
        [InlineData('C', 40, 2, 80)]
        [InlineData('D', 55, 2, 82.5)]
        public void BaskItem_PromotionCalculator_Should_Return_Valid_TotalPrice(char itemSku, decimal price, int quantity, decimal expected)
        {
            IBasketItem item = new BasketItem
            {
                ItemSku = itemSku,
                Price = price,
                Quantity = quantity
            };

            item.Calculate(_promotionCalculator);

            Assert.Equal(expected, item.TotalPrice);
        }

        [Theory]
        [InlineData('A', 10, 2, 21)]
        [InlineData('B', 15, 3, 41)]
        [InlineData('C', 40, 2, 81)]
        [InlineData('D', 55, 2, 83.5)]
        public void BaskItem_PromotionCalculator_Should_Not_Return_Valid_TotalPrice(char itemSku, decimal price, int quantity, decimal expected)
        {
            IBasketItem item = new BasketItem
            {
                ItemSku = itemSku,
                Price = price,
                Quantity = quantity
            };

            item.Calculate(_promotionCalculator);

            Assert.NotEqual(expected, item.TotalPrice);
        }
    }
}
