using AYellowpaper.SerializedCollections;
using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Weapons/New Gun")]
public class GunDefinition : WeaponDefinition
{
    [field: Header("Gun Definition")]
    [field: SerializeField] public int FireRate { get; private set; }
    [field: SerializeField] public ComponentType[] CrucialComponents { get; protected set; }
    [field: SerializeField] public SerializedDictionary<ComponentType, GunComponentDefinition[]> Components { get; protected set; } // all the possible gun parts
    [field: SerializeField] public SerializedDictionary<ComponentType, GunComponentDefinition> DefaultComponents { get; protected set; }
    [field: SerializeField] public Firemode[] Firemodes { get; protected set; }
    [field: SerializeField] public Firemode DefaultFiremode { get; protected set; }
    public GunDefinition() : base(WeaponType.GUN)
    {

    }
}

[Serializable]
public class GunData : WeaponData
{
    public int FireRate { get; set; }
    public ComponentType[] CrucialComponents { get; set; }
    public SerializedDictionary<ComponentType, GunComponentDefinition> Components { get; set; }
    public Firemode[] Firemodes { get; set; }
    public Firemode SelectedFiremode { get; set; }
}

public interface IGun : IWeaponData
{
    public int FireRate { get; }
    public ComponentType[] CrucialComponents { get; }
    public SerializedDictionary<ComponentType, GunComponentDefinition> Components { get; }
    public Firemode[] Firemodes { get; }
    public Firemode SelectedFiremode { get; }
}