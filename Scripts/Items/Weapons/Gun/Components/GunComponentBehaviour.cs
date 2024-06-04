using UnityEngine;

public abstract class GunComponentBehaviour<T> : AbstractItemBehaviour<T> where T : GunComponent
{
    
}

public enum ComponentType
{
    Bolt, Barrel, Magazine, Chamber, GasTube, Mount
}