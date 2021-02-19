using System.Collections.Generic;
using System.Linq;

namespace Kata.Checkout
{
    public class Item : IItem
    {
        public char ItemSku { get; set; }
        public decimal Price { get; set; }
    }

    public interface IItemCollection
    {
        List<IItem> GridItems { get; }
        IItem GetBySku(char itemSku);
    }

    public class ItemCollection : IItemCollection
    {
        public List<IItem> GridItems { get; }

        public ItemCollection()
        {
            GridItems = new List<IItem>();
            GridItems.AddRange(new List<IItem>
            {
                new Item {ItemSku = 'A', Price = 10},
                new Item {ItemSku = 'B', Price = 15},
                new Item {ItemSku = 'C', Price = 40},
                new Item {ItemSku = 'D', Price = 55},
            });
        }

        public IItem GetBySku(char itemSku)
        {
            return GridItems.First(i => i.ItemSku == itemSku);
        }
    }
}