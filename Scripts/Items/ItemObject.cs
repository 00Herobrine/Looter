using System;
using UnityEngine;

public class ItemObject : ItemDefinition, IItemData // Player Owned Items
{
    [field: Header("Item Info")]
    [field: SerializeField] public string GUID { get; protected set; }
    [field: SerializeField] public string OwnerID { get; protected set; }
    public int Width => Shape.Width;
    public int Height => Shape.Height;
    public ItemObject(ItemType itemType) : base(itemType) { }
    public ItemObject(ItemDefinition itemDefinition, string ownerID)
        : base(itemDefinition.Type)
    {
        // Copy data from the item definition
        UUID = itemDefinition.UUID;
        Name = itemDefinition.Name;
        Description = itemDefinition.Description;
        UnitPrice = itemDefinition.UnitPrice;
        Icon = itemDefinition.Icon;
        Rarity = itemDefinition.Rarity;
        Prefab = itemDefinition.Prefab;
        Radius = itemDefinition.Radius;
        Shape = itemDefinition.Shape;

        // Set instance-specific data
        GUID = Guid.NewGuid().ToString();
        OwnerID = ownerID;
    }
}

public interface IItemData
{
    string GUID { get; }
    string OwnerID { get; }
}



public class FoldableItem : ItemObject
{
    [field: SerializeField] public CellBlock FoldedShape { get; protected set; }
    public FoldableItem(ItemType itemType) : base(itemType) { }
}