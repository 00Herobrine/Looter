using UnityEngine;

public abstract class GunComponentDefinition : ItemDefinition
{
    [field: Header("Component Info")]
    [field: SerializeField] public ComponentType ComponentType { get; protected set; }
    public GunComponentDefinition(ComponentType componentType) : base(ItemType.Component) 
    {
        ComponentType = componentType;
    }
}