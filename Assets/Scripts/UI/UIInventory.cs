using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    public List<UIItem> UIItems = new List<UIItem>();
    public GameObject SlotPrefab;
    public Transform SlotPanel;
    public int NumberOfSlots;

    private void Awake()
    {
        for (int i = 0; i < NumberOfSlots; i++) 
        {
            GameObject instance = Instantiate(SlotPrefab);
            instance.transform.SetParent(SlotPanel);
            UIItems.Add(instance.GetComponentInChildren<UIItem>());
        }
    }

    public void UpdateSlot(int slot, Item item)
    {
        UIItems[slot].UpdateItem(item);
    }

    public void AddNewItem(Item item)
    {
        UpdateSlot(UIItems.FindIndex(i => i.Item == null), item);
    }

    public void RemoveItem(Item item)
    {
        UpdateSlot(UIItems.FindIndex(i => i.Item == item), null);
    }
}
