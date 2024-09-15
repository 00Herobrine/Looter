using UnityEngine;

[CreateAssetMenu(menuName = "Items/Containers/New Container", fileName = "New Resource Container")]
public class ResourceContainerDefintion : ContainerDefinition, IStackable
{
    [field: Header("Resource Container Info")]
    [field: SerializeField] public int Count { get; private set; }
    [field: SerializeField] public int MaxCount { get; private set; }
}
