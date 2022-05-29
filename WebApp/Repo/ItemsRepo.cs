using System;
using System.Collections.Generic;
using System.Linq;
using WebApp.Model;

namespace WebApp.Repo
{
    public class InMemItemsRepository
    {
        private readonly List<Item> items = new()
        {   // initialize a list of items
            new Item { Id= Guid.NewGuid(), Name= "Potion", Price=9, CreatedDate=DateTimeOffset.UtcNow},
            new Item { Id= Guid.NewGuid(), Name= "Iron Swords", Price=20, CreatedDate=DateTimeOffset.UtcNow},
            new Item { Id= Guid.NewGuid(), Name= "Bronze Shield", Price=18, CreatedDate=DateTimeOffset.UtcNow}
        };

        public IEnumerable<Item> GetItems()
        {   // get all items
            return items;
        }

        public Item GetItem(Guid id)
        {   // get a single item bases on id
            return items.Where(item => item.Id==id).SingleOrDefault();
        }

    }
}