using System;
using System.Collections.Generic;
using UnityEngine;

public class GunBehaviour : AbstractWeaponBehaviour<GunData>
{
    [field: Header("Gun Info")]
    [field: SerializeField] public List<ComponentAttachPoint> ComponentLocations { get; private set; }
}

[Serializable]
public struct ShootData
{
    public int damage;
    public float recoil;
    public float accuracy;
}

[Serializable]
public class ComponentAttachPoint
{
    public ComponentType type;
    public Transform attachPoint;
}

public abstract class GunComponentBehaviour : ItemBehaviour
{
    [field: SerializeField] public ComponentAttachPoint[] Proxies { get; protected set; }
    [field: SerializeField] public GunComponentBehaviour[] AttachedComponents { get; protected set; }
    //public ComponentType ComponentType => Definition.ComponentType;
    protected void InitializeComponents() 
    {
        //foreach (GunComponentBehaviour component in AttachedComponents)
            //Instantiate(component);
    }
    public abstract ShootData Shoot(ShootData data);
}

public class AttachmentPoint
{
    
}

public enum AttachmentType
{
    Stock, Grip, Optic
}