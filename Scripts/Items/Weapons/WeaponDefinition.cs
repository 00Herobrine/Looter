using System;
using UnityEngine;

public abstract class WeaponDefinition : ItemDefinition
{
    [field: Header("Weapon Definition")]
    [field: SerializeField] public WeaponType WeaponType { get; protected set; }
    [field: SerializeField] public float AttackRate { get; protected set; }

    public WeaponDefinition(WeaponType weaponType) : base(ItemType.Weapon)
    {
        WeaponType = weaponType;
    }
}

[Serializable]
public class WeaponData : ItemData, IWeaponData
{
    [field: SerializeField] public WeaponType WeaponType { get; set; }
    [field: SerializeField] public double LastAttack { get; set; }
    [field: SerializeField] public float Cooldown { get; set; }
}

public interface IWeaponData : IItemData
{
    WeaponType WeaponType { get; }
    double LastAttack { get; }
    float Cooldown { get; }
}