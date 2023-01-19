using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIItem : MonoBehaviour
{
    public Item Item;
    private Image spriteImage;

    private void Awake()
    {
        spriteImage = GetComponent<Image>();
        UpdateItem(null);
    }

    public void UpdateItem(Item item)
    {
        this.Item = item;
        if (this.Item != null)
        {
            spriteImage.color = Color.white;
            spriteImage.sprite = this.Item.ItemIcon;
        } 
        else
        {
            spriteImage.color = Color.clear;
        }
    }
}
