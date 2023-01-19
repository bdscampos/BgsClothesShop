using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> PlayerItems = new List<Item>();
    public ItemDatabase ItemDatabase;
    public UIInventory UIInventory;

    public void AddItem(int id)
    {
        Item item = ItemDatabase.GetItem(id);
        PlayerItems.Add(item);
        UIInventory.AddNewItem(item);
    }

    public Item GetItem(int id)
    {
        return PlayerItems.Find(item => item.Id == id);
    }

    public void RemoveItem(int id)
    {
        if (GetItem(id) != null)
        {
            PlayerItems.Remove(GetItem(id));
            UIInventory.RemoveItem(GetItem(id));
        }

    }
}
