using UnityEngine;

public class ComponentDefinition : ItemObject
{
    [field: Header("Component Info")]
    [field: SerializeField] public ComponentType ComponentType { get; private set; }
    public ComponentDefinition(ComponentType componentType) : base(ItemType.Component) 
    {
        ComponentType = componentType;
    }
}