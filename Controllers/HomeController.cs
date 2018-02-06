using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      return View();
    }

    // [Route("/item/list")]
    // public ActionResult ItemList()
    // {
    //   Item newItem = new Item(Request.Query["new-item"]);
    //   return View(newItem);
    // }

    [HttpPost("/item/create")]
    public ActionResult CreateItem()
    {
      Item newItem = new Item(Request.Form["new-item"]);
      newItem.Save();
      return View(newItem);
    }

    [HttpGet("/item/list")]
    public ActionResult ItemList()
    {
      List<string> allItems = Item.GetAll();
      return View(allItems);
    }

    [HttpPost("/item/list/clear")]
    public ActionResult ItemListClear()
    {
      Item.ClearAll();
      return View();
    }
  }
}
