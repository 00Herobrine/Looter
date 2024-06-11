using Unity.Netcode;
using UnityEngine;

public class AbstractItemBehaviour<T> : NetworkBehaviour where T : BaseItem
{
    [field: SerializeField] public T ItemData { get; private set; }

    private void Awake()
    {
        Initialize();
    }

    public override void OnNetworkSpawn()
    {
    }

    public override void OnNetworkDespawn()
    {

    }

    public virtual void Initialize() { }
}


public class AbstractItemStackBehaviour<T> : AbstractItemBehaviour<T> where T : BaseItemStack
{

}