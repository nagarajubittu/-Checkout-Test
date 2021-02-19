using Xunit;

namespace Kata.Checkout.Tests
{
    public class BasketTests
    {
        private readonly IItemCollection _itemCollection = new ItemCollection();
        private readonly IBasket _classUnderTest = new Basket(new PromotionCalculator());

        [Fact]
        public void Basket_Should_Return_Valid_TotalPrice()
        {
            _classUnderTest.AddItem(new BasketItem
            {
                ItemSku = 'A',
                Price = _itemCollection.GetBySku('A').Price,
                Quantity = 1,
            });

            _classUnderTest.AddItem(new BasketItem
            {
                ItemSku = 'B',
                Price = _itemCollection.GetBySku('B').Price,
                Quantity = 7,
            });

            _classUnderTest.AddItem(new BasketItem
            {
                ItemSku = 'C',
                Price = _itemCollection.GetBySku('C').Price,
                Quantity = 1,
            });

            _classUnderTest.AddItem(new BasketItem
            {
                ItemSku = 'D',
                Price = _itemCollection.GetBySku('D').Price,
                Quantity = 7,
            });

            Assert.Equal(447.5M, _classUnderTest.TotalPrice);
        }

        [Fact]
        public void Basket_Should_Not_Return_Valid_TotalPrice()
        {
            _classUnderTest.AddItem(new BasketItem
            {
                ItemSku = 'A',
                Price = _itemCollection.GetBySku('A').Price,
                Quantity = 2,
            });

            _classUnderTest.AddItem(new BasketItem
            {
                ItemSku = 'B',
                Price = _itemCollection.GetBySku('B').Price,
                Quantity = 7,
            });

            _classUnderTest.AddItem(new BasketItem
            {
                ItemSku = 'C',
                Price = _itemCollection.GetBySku('C').Price,
                Quantity = 1,
            });

            _classUnderTest.AddItem(new BasketItem
            {
                ItemSku = 'D',
                Price = _itemCollection.GetBySku('D').Price,
                Quantity = 7,
            });

            Assert.NotEqual(447.5M, _classUnderTest.TotalPrice);
        }
    }
}