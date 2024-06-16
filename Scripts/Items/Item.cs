using System;
using UnityEngine;

public class Item : AbstractItem<ItemData>
{
    public void weef()
    {
        
    }
    public override void Use()
    {
    }
}

[Serializable]
public class ItemData : AbstractItemData<ItemDefinition>, IItemData
{
    public string GUID { get; set; } // Unique ID of Item Instance
    public string OwnerID { get; set; } // ID of last person to interact with item
    #nullable enable
    private string? DisplayName;
    // NameUpdatedEvent => refresh UI element(s)
    public string Name 
    { 
        get => !string.IsNullOrEmpty(DisplayName) ?  DisplayName : ItemDefinition.Name;
        set => SetName(value);
    }

    protected void SetName(string value)
    {
        DisplayName = value;
    }
}
