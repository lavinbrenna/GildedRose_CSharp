using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        // [Fact]
        // public void foo()
        // {
        //     IList<Item> Items = new List<Item> { new Item { Name = "fixme", SellIn = 0, Quality = 0 } };
        //     GildedRose app = new GildedRose(Items);
        //     app.UpdateQuality();
        //     Assert.Equal("foo", Items[0].Name);
        // }
        [Fact]
        public void FooQuality_DoesNotReturnNegative()
        {
            IList<Item> Items = new List<Item> 
            {
                new Item {Name = "foo", SellIn = -1, Quality = 0},
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(0, Items[0].Quality);
        }
        [Fact]
        public void FooQuality_GoesDownDoublePastSellInDate()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "foo", SellIn = -2, Quality = 25}
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(23, Items[0].Quality);
        }
        [Fact]
        public void RagnarosQuality_DoesNotGoOver80()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80}
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(80, Items[0].Quality);
        }

        [Fact]
        public void ConjuredQuality_QualityDropsDouble()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Conjured Mana", SellIn = -1, Quality = 49}
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(45, Items[0].Quality);
        }

        [Fact]
        public void BackstagePasses_DropToZeroAfterConcert()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -1, Quality = 40}
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(0, Items[0].Quality);
        }
        [Fact]
        public void BackstagePasses_IncreaseByThreeBeforeConcert()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 40}
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(43, Items[0].Quality);
        }
            [Fact]
        public void BackstagePasses_IncreaseByTwoBeforeConcert()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 40}
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(42, Items[0].Quality);
        }
        [Fact]
        public void AgedBrie_QualityIncreases()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Aged Brie", SellIn = 3, Quality = 40}
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(41, Items[0].Quality);
        }

        [Fact]
        public void AgedBrie_QualityIncreasesEvenAfterSellIn()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Aged Brie", SellIn = -3, Quality = 39}
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(40, Items[0].Quality);
        }
    }
}
