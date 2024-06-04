using UnityEngine;

public class GunComponent : Item
{
    [field: Header("Component Info")]
    [field: SerializeField] public ComponentType ComponentType { get; private set; }
    public GunComponent(ComponentType componentType) : base(ItemType.Component) 
    {
        ComponentType = componentType;
    }
}