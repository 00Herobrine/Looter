using UnityEngine;

public abstract class AbstractContainerItemData<T> : Item where T : BaseItem
{
    [field: Header("Container Info")]
    [field: SerializeField] public T Stored { get; private set; }
    public AbstractContainerItemData() : base(ItemType.Container) { }
}