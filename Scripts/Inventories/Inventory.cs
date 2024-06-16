using UnityEngine;

public class Inventory
{
    public Vector2Int Size { get; protected set; }
    public InventorySlot[,] Contents { get; protected set; }

    public Inventory(int columns, int rows)
    {
        Size = new Vector2Int(columns, rows);
        Contents = new InventorySlot[columns, rows];
    }

    public void SetItem<T>(int x, int y, T item) where T : ItemObject
    {
        SetItem(new(x, y), item);
    }
    public void SetItem<T>(Vector2Int pos, T item) where T : ItemObject
    {
        Contents[pos.x, pos.y].SetItem(item);
    }

    public T GetItem<T>(int x, int y) where T : Item
    {
        return null;
    }
}

public class InventorySlot
{
    public ItemObject _item { get; private set; }
    public ItemType[] BlacklistedTypes { get; private set; }
    public string[] BlacklistedIDs { get; private set; }
    public ItemObject Item { 
        get => _item;
        set 
        { 
            if(_item == value || IsBlacklisted(value)) return;
            _item = value;
        }
    }
    public bool IsBlacklisted(ItemObject item) => IsBlacklisted(item.Type) || IsBlacklisted(item.UUID);
    public bool IsBlacklisted(string itemGUID)
    {
        foreach(string id in BlacklistedIDs)
            if(id == itemGUID) return true;
        return false;
    }
    public bool IsBlacklisted(ItemType itemType) {
        foreach (ItemType type in BlacklistedTypes)
            if (type == itemType) return true;
        return false;
    }
    public void SetItem<T>(T item) where T : ItemObject
    {
        Item = item;
    }
    public T GetItem<T>() where T : ItemObject => _item as T;
}