using System;
using UnityEngine;

[Serializable]
public class InventoryData : ScriptableObject
{
    ContainerDefinition container;

    public void AddItem(ItemDefinition item)
    {

    }
    public void AddItem(ItemStackDefinition itemStack)
    {

    }
    public void RemoveItem(ItemDefinition item) { }

    public void SetItem(ItemDefinition item, int x, int y) => SetItem(item, new(x, y));
    public void SetItem(ItemDefinition item, Vector2Int position)
    {

    }
}
