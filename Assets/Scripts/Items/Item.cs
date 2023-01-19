using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public int Id;
    public int Cost;
    public string ItemName;
    public string ItemDescription;
    public Sprite ItemIcon;

    public Item (int id, int cost, string itemName, string itemDescription)
    {
        this.Id = id;
        this.Cost = cost;
        this.ItemName = itemName;
        this.ItemDescription = itemDescription;
    }

    public Item(Item item)
    {
        this.Id = item.Id;
        this.Cost = item.Cost;
        this.ItemName = item.ItemName;
        this.ItemDescription = item.ItemDescription;
    }
}

