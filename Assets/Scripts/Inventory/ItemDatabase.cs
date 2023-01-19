using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    private void Awake()
    {
        CreateItemDatabase();
    }

    public Item GetItem(int id)
    {
        return items.Find(item => item.Id == id);
    }

    public void CreateItemDatabase()
    {
        items = new List<Item>()
        {
            new Item(0, 50, "Blue Shirt", "A simple blue shirt."),
            new Item(0, 50, "White Dress", "A fancy white dress.")
        };
    }
}
