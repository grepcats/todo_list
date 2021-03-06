using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    private string _description;
    private int _id;
    private int _categoryId;

    private static List<Item> _instances = new List<Item> {};

    public Item (string description, int catId)
    {
      _description = description;
      _instances.Add(this);
      _id = _instances.Count;
      _categoryId = catId;
    }

    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public int GetId()
    {
      return _id;
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Item Find(int searchId)
    {
      return _instances[searchId];
    }

    public void SetCatId(int newCatId)
    {
        _categoryId = newCatId;
    }

    public int GetCatId()
    {
        return _categoryId;
    }
  }
}
