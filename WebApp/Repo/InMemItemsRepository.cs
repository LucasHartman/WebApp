using System;
using System.Collections.Generic;
using WebApp.Model.Item;


namespace WebApp.Repo
{
    public class InMemItemsRepository
    {
        private readonly List<Item> items = new()
        {   // initialize a list of items
            new Item { Id= Guide.NewGuid(), nameof= "Potion", Price=9, CreatedDate=DateTimeOffSet.UTcNow},
            new Item { Id= Guide.NewGuid(), nameof= "Iron Swords", Price=20, CreatedDate=DateTimeOffSet.UTcNow},
            new Item { Id= Guide.NewGuid(), nameof= "Bronze Shield", Price=18, CreatedDate=DateTimeOffSet.UTcNow}
        };

        public IEnumberable<Item> GetItems()
        {   // get all items
            return items;
        }

        public Item GetItem(Guide id)
        {   // get a single item bases on id
            return items.Where(item => item.id==id).SingleOrDefault();
        }

    }
}