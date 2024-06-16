using UnityEngine;

public abstract class AbstractContainerItemData<T> : ItemData where T : ItemData
{
    [field: Header("Container Info")]
    [field: SerializeField] public T[] Stored { get; private set; }
}