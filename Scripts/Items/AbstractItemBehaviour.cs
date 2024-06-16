using Unity.Netcode;
using UnityEngine;

public abstract class AbstractItemBehaviour<T> : NetworkBehaviour where T : ItemData
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


public abstract class AbstractItemStackBehaviour<T> : AbstractItemBehaviour<T> where T : ItemStackData
{

}