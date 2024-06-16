using UnityEngine;

public abstract class ResourceDefinition : ItemDefinition
{
    //public const int DEFAULT_MAX_RESOURCE = 100;
    public ResourceDefinition() : base(ItemType.Resource) { }
}
