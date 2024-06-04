using Unity.Netcode;
using UnityEngine;

public class AbstractItemBehaviour<T> : NetworkBehaviour where T : BaseItem
{
    [field: SerializeField] public T ItemData { get; private set; }
    public override void OnNetworkSpawn()
    {
        
    }

    public override void OnNetworkDespawn()
    {

    }
}


public class AbstractItemStackBehaviour<T> : AbstractItemBehaviour<T> where T : BaseItemStack
{

}