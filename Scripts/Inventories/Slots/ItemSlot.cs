using System;
using UnityEngine;

[Serializable]
public class ItemSlot : AbstractItemSlot<ItemDefinition>
{
    public ItemSlot(ItemDefinition item)
    {
        Item = item;
    }
}