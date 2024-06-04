using System;
using UnityEngine;

public class Item : BaseItem // Player Owned Items
{
    [field: Header("Item Info")]
    [field: SerializeField] public string GUID { get; private set; } = Guid.NewGuid().ToString();
    [field: SerializeField] public string OwnerID { get; private set; }
    [field: SerializeField] public CellBlock Shape { get; protected set; }
    public int Width => Shape.Width;
    public int Height => Shape.Height;
    public Item(ItemType itemType) : base(itemType) { }
}

public class ItemStack : BaseItemStack
{
    //[field: Header("Stack Info")]
    //[field: SerializeField, Min(1)] public NetworkVariable<int> Count { get; private set; } = new NetworkVariable<int>(1);
    public ItemStack(ItemType itemType) : base(itemType) { }
}

public class FoldableItem : Item
{
    [field: SerializeField] public CellBlock FoldedShape { get; protected set; }
    public FoldableItem(ItemType itemType) : base(itemType) { }
}