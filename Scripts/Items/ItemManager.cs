using System;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : SingletonBehaviour<ItemManager>
{
    [field: Header("Item Manager")]
    [field: SerializeField] public ItemDefinition[] ItemDefinitions { get; private set; }
    private Dictionary<string, ItemDefinition> definitionLookup; // UUID, ItemDefinition

    protected override void Awake()
    {
        base.Awake();
        StoreDefinitions();
    }

    private void StoreDefinitions()
    {
        foreach (ItemDefinition definition in ItemDefinitions)
            definitionLookup.Add(definition.UUID, definition);
    }

    public T GetDefinition<T>(string UUID) where T : ItemDefinition
    {
        return (T) GetItemDefinition(UUID);
    }
    public ItemDefinition GetItemDefinition(string uuid)
    {
        foreach(ItemDefinition definition in ItemDefinitions)
            if(definition.UUID == uuid)
                return definition;

        Debug.LogError($"Definition with UUID {uuid} not found.");
        return null;
    }
    public ItemDefinition GetItemDefinitionByName(string name)
    {
        if(definitionLookup.TryGetValue(name, out var definition)) 
            return definition;

        Debug.LogError($"Definition with Name {name} not found.");
        return null;
    }

    public void AddItem(string itemUUID, int quantity)
    {
        
    }

    internal static string GenerateID()
    {
        return Guid.NewGuid().ToString();
    }
}