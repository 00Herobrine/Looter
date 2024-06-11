using AYellowpaper.SerializedCollections;
using UnityEngine;

public abstract class GunComponentBehaviour<T> : AbstractItemBehaviour<T> where T : GunComponent
{
    [field: SerializeField] public SerializedDictionary<ComponentType, Transform> ComponentProxy { get; private set; }
}

public enum ComponentType
{
    Bolt, Barrel, Magazine, Chamber, GasTube, Mount, Lower, Upper
}