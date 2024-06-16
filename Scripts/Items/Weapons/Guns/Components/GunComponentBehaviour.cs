using AYellowpaper.SerializedCollections;
using System;
using UnityEngine;

// DamageableComponent more like
public abstract class GunComponentBehaviour<T> : AbstractItemBehaviour<T> where T : ItemData
{
    [field: SerializeField] public SerializedDictionary<ComponentType, ComponentStruct> ComponentProxy { get; private set; }
    public override void Initialize()
    {
        
    }
}

[Serializable]
public struct ComponentStruct
{
    [field: SerializeField] public Transform Transform { get; private set; }
    [field: SerializeField] public ComponentDefinition Component { get; private set; }
}

public enum ComponentType
{
    Bolt, Barrel, Magazine, Chamber, GasTube, Mount, Lower, Upper
}