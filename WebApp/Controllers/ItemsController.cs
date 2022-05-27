using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApp.Controllers;

[ApiController]
[Route("items")]
public class ItemsController : ControllerBase
{
    private readonly ItemsRepo repository; // get repo

    public ItemsController()
    { // Constructor 
        repository = new InMemItemsRepository(); // Initialize Repo
    }

    // GET / items
    [HttpGet]
    public IEnumberable<Item> GetItems()
    { // Get all Items
        var items = repository.GetItems(); // initialize method from Repo
        return items;
    }
}
