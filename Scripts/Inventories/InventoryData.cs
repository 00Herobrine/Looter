using System;
using UnityEngine;

[Serializable]
public class InventoryData : ScriptableObject
{
    ContainerDefinition container;

    public void AddItem(ItemObject item)
    {

    }
    public void AddItem(ItemStackDefinition itemStack)
    {

    }
    public void RemoveItem(ItemObject item) { }

    public void SetItem(ItemObject item, int x, int y) => SetItem(item, new(x, y));
    public void SetItem(ItemObject item, Vector2Int position)
    {

    }
}
