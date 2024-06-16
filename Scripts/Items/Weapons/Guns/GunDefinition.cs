using AYellowpaper.SerializedCollections;
using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Weapons/New Gun")]
public class GunDefinition : WeaponDefinition, IGun
{
    public int FireRate { get; private set; }
    //public float Cooldown { get; protected set; } // (60 / FireRate) typically but can differ for varying RPM
    public ComponentType[] CrucialComponents { get; protected set; }
    public SerializedDictionary<ComponentType, ComponentDefinition> Components { get; protected set; }
    public Firemode[] Firemodes { get; protected set; }
    public Firemode SelectedFiremode { get; protected set; }
    public GunDefinition() : base(WeaponType.GUN)
    {

    }
}

[Serializable]
public class GunData : WeaponData
{
    public int FireRate { get; set; }
    public ComponentType[] CrucialComponents { get; set; }
    public SerializedDictionary<ComponentType, ComponentDefinition> Components { get; set; }
    public Firemode[] Firemodes { get; set; }
    public Firemode SelectedFiremode { get; set; }
}

public interface IGun : IWeapon
{
    public int FireRate { get; }
    public ComponentType[] CrucialComponents { get; }
    public SerializedDictionary<ComponentType, ComponentDefinition> Components { get; }
    public Firemode[] Firemodes { get; }
    public Firemode SelectedFiremode { get; }
}