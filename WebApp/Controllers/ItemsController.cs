using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApp.Model;
using WebApp.Repo;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        private readonly InMemItemsRepository repository; // get repo

        public ItemsController()
        { // Constructor 
            repository = new InMemItemsRepository(); // Initialize Repo
        }

        // GET / items
        [HttpGet]
        public IEnumerable<Item> GetItems()
        { // Get all Items
            var items = repository.GetItems(); // initialize method from Repo
            return items;
        }

    }
}