using System;
using UnityEngine;
using UnityEngine.Events;

public class ItemBehaviour : AbstractItemBehaviour<ItemData>
{
    public UnityEvent<ItemData> ItemUsedEvent;
    public void weef()
    {
        
    }

    public virtual bool CanUse() => true; 

    public virtual void Use()
    {
        if (!CanUse()) return;
        ItemUsedEvent?.Invoke(ItemData);
    }
}

[Serializable]
public class ItemData : AbstractItemData<ItemDefinition>, IItemData
{
    [field: SerializeField] public string GUID { get; protected set; } // Unique ID of Item Instance
    [field: SerializeField] public string OwnerID { get; protected set; } // ID of last person to interact with item
    #nullable enable
    [field: SerializeField] private string? DisplayName;
    // NameUpdatedEvent => refresh UI element(s)
    public ItemData() { }
    public ItemData(string uuid)
    {
        ItemDefinition definition = ItemManager.Instance.GetItemDefinition(uuid);
        UUID = definition.UUID;
        GUID = ItemManager.GenerateID();
    }
    public string Name 
    { 
        get => !string.IsNullOrEmpty(DisplayName) ?  DisplayName : Definition.Name;
        set => SetName(value);
    }

    protected void SetName(string value)
    {
        DisplayName = value;
    }
}
