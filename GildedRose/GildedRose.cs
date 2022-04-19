using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }
        public void UpdateQuality()
        {
            foreach(Item item in Items){
                if(item.Name == "Sulfuras, Hand of Ragnaros"){
                    item.Quality = 80;
                }
                if(item.Quality >= 0 && item.Quality <= 50)
                {
                    if(item.Name == "Aged Brie")
                    {
                        item.Quality += 1;
                        if(item.Quality + 1 > 50)
                        {
                            item.Quality = 50;
                        }
                    }
                    else if(item.Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if(item.SellIn < 0 && item.Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            item.Quality = 0;
                        }
                        else if(item.SellIn <= 10 && item.SellIn > 5)
                        {
                            item.Quality += 2;
                            if(item.Quality + 2 > 50)
                            {
                                item.Quality = 50;
                            }
                        }
                        else if(item.SellIn <= 5 && item.SellIn >= 0)
                        {
                            item.Quality += 3;
                            if(item.Quality + 3 > 50)
                            {
                                item.Quality = 50;
                            }
                        }
                        else
                        {
                            item.Quality += 1;
                            if(item.Quality +1 > 50)
                            {
                                item.Quality = 50;
                            }
                        }
                    }
                    else if(!item.Name.Contains("Conjured")){
                        if(item.SellIn > 0){
                            item.Quality -= 1;
                            if(item.Quality - 1 < 0 )
                            {
                                item.Quality = 0;
                            }
                        }
                        else{
                            item.Quality -= 2;
                            if(item.Quality -2 < 0)
                            {
                                item.Quality = 0;
                            }
                        }
                    }
                    else
                    {
                        if(item.SellIn > 0)
                        {
                            item.Quality -= 2;
                            if(item.Quality - 2 < 0)
                            {
                                item.Quality = 0;
                            }
                        }
                        else
                        {
                            item.Quality -= 4;
                            if(item.Quality - 4 < 0)
                            {
                                item.Quality = 0;
                            }
                        }
                        }
                    }
                }
            }
        }
    }
 