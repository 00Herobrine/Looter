using System;
using UnityEngine;

[Serializable]
public class Inventory : ScriptableObject
{
    Container container;

    public void AddItem(Item item)
    {

    }
    public void RemoveItem(Item item) { }

    public void SetItem(Item item, int x, int y) => SetItem(item, new(x, y));
    public void SetItem(Item item, Vector2Int position)
    {

    }
}
