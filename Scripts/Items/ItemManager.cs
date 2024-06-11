using Unity.Netcode;
using UnityEngine;

public class ItemManager : NetworkSingletonBehavior<ItemManager>
{

    [ServerRpc]
    public void SpawnItemServerRpc(Vector3 position)
    {
        //GameObject item = Instantiate(itemPrefab, position, Quaternion.identity);
    }
}