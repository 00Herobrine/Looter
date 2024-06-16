using Unity.Netcode;
using UnityEngine;

public class ItemManager : SingletonBehavior<ItemManager>
{
    [field: Header("Allowed Items")]
    [field: SerializeField] public ItemDefinition[] Items { get; private set; }

    public T GetItemDefinition<T>(string UUID) where T : ItemDefinition
    {
        return (T) GetItemDefinition(UUID);
    }
    public ItemDefinition GetItemDefinition(string UUID)
    {
        foreach(ItemDefinition definition in Items)
            if(definition.UUID == UUID)
                return definition;
        return null;
    }
    
    [ServerRpc]
    public void SpawnItemServerRpc(Vector3 position)
    {
        //GameObject item = Instantiate(itemPrefab, position, Quaternion.identity);
    }
}