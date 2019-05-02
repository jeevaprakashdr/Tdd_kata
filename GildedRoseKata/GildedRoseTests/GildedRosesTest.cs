using System.Collections.Generic;
using GildedRose;
using Xunit;

namespace GildedRoseTests
{
    public class GildedRosesTest
    {
        [Fact]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRoses app = new GildedRoses(Items);
            app.UpdateQuality();
            Assert.Equal("fixme", Items[0].Name);
        }
    }
}