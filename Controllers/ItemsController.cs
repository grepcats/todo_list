using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Controllers
{
  public class ItemsController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      return View("Index");
    }

    [HttpGet("/items")]
    public ActionResult Items()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }

    [HttpGet("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create()
    {
      Item newItem = new Item(Request.Form["new-item"]);
      List<Item> allItems = Item.GetAll();
      return View("Items", allItems);
    }

    [HttpGet("/items/{id}")]
    public ActionResult Detail(int id)
    {
      Item item = Item.Find(id);
      return View(item);
    }
  }
}
