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

    public void SetItem<T>(int x, int y, T item) where T : ItemDefinition
    {
        SetItem(new(x, y), item);
    }
    public void SetItem<T>(Vector2Int pos, T item) where T : ItemDefinition
    {
        Contents[pos.x, pos.y].SetItem(item);
    }

    public T GetItem<T>(int x, int y) where T : ItemBehaviour
    {
        return null;
    }
}

public class InventorySlot
{
    public ItemDefinition _item { get; private set; }
    public ItemType[] BlacklistedTypes { get; private set; }
    public string[] BlacklistedIDs { get; private set; }
    public ItemDefinition Item { 
        get => _item;
        set 
        { 
            if(_item == value || IsBlacklisted(value)) return;
            _item = value;
        }
    }
    public bool IsBlacklisted(ItemDefinition item) => IsBlacklisted(item.Type) || IsBlacklisted(item.UUID);
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
    public void SetItem<T>(T item) where T : ItemDefinition
    {
        Item = item;
    }
    public T GetItem<T>() where T : ItemDefinition => _item as T;
}