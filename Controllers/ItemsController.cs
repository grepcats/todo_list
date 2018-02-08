using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.Models;
using System;

namespace ToDoList.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/categories/{categoryId}/items/new")]
    public ActionResult CreateItemForm(int categoryId)
    {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Category foundCategory = Category.Find(categoryId);
        List<Item> allItems = foundCategory.GetItems();
        model.Add("category", foundCategory);
        model.Add("items", allItems);
        return View("CreateItemForm", model);
    }

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
