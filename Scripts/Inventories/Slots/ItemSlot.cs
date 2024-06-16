using System;
using UnityEngine;

[Serializable]
public class ItemSlot : AbstractItemSlot<ItemObject>
{
    public ItemSlot(ItemObject item)
    {
        Item = item;
    }
}