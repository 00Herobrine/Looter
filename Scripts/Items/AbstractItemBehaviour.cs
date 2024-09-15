using System;
using Unity.Netcode;
using UnityEngine;

public abstract class AbstractItemBehaviour<T> : NetworkBehaviour where T : ItemData
{
    [field: SerializeField] public T ItemData { get; protected set; }

    public override void OnNetworkSpawn()
    {
        Initialize();
    }

    public override void OnNetworkDespawn()
    {

    }

    public virtual void Initialize() { }
}

[Serializable]
public abstract class AbstractItemData<T> where T : ItemDefinition
{
    [field: SerializeField] public string UUID { get; set; } // ItemID
    public T Definition => (T) ItemManager.Instance.GetItemDefinition(UUID);
    //public virtual T GetDefinition<T>() where T : ItemDefinition => (T) ItemManager.Instance.GetItemDefinition(UUID);
    //public virtual T Definition => (T)ItemManager.Instance.GetItemDefinition(UUID);
}


public abstract class AbstractItemStackBehaviour<T> : AbstractItemBehaviour<T> where T : ItemStackData
{

}

public abstract class AbstractItemStackData<T> where T : ItemStackDefinition
{
    public int Count { get; set; }
    public int MaxCount { get; set; }
}