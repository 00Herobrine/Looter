using Unity.Netcode;

public abstract class AbstractItem<T> : NetworkBehaviour where T : ItemData
{
    public T ItemData { get; private set; }
    public abstract void Use();
}


public abstract class AbstractItemData<T> where T : ItemDefinition
{
    public string UUID { get; set; } // ItemID
    public virtual T ItemDefinition => (T) ItemManager.Instance.GetItemDefinition(UUID);

}