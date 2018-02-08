using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.Models;
using System;

namespace ToDoList.Controllers
{
  public class ItemsController : Controller
  {
    // [HttpGet("/items")]
    // public ActionResult Index()
    // {
    //   return View("Index", Item.GetAll());
    // }
    //
    // [HttpPost("/categories/items")]
    // public ActionResult Details()
    // {
    //     Dictionary<string, object> model = new Dictionary<string, object>();
    //     int foundCategoryId = Int32.Parse(Request.Form["category-id"]);
    //     Category foundCategory = Category.Find(foundCategoryId);
    //     List<Item> categoryItems = foundCategory.GetItems();
    //     string itemDescription = Request.Form["item-description"];
    //     Item newItem = new Item(itemDescription, foundCategoryId);
    //     categoryItems.Add(newItem);
    //     model.Add("items", categoryItems);
    //     model.Add("category", foundCategory);
    //     return View("Details", model);
    // }


    [HttpGet("/items/{id}")]
    public ActionResult Details(int id)
    {
        Item item = Item.Find(id);
        Dictionary<string, object> model = new Dictionary<string, object>();
        Category category = Category.Find(item.GetCatId());
        model.Add("item", item);
        model.Add("category", category);
        return View(item);
    }
  }
}
