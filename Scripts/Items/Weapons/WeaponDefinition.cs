using System;
using UnityEngine;

public abstract class WeaponDefinition : ItemDefinition, IWeapon
{
    [field: Header("Weapon Info")]
    [field: SerializeField] public WeaponType WeaponType { get; protected set; }
    [field: SerializeField] public double LastAttack { get; protected set; }
    [field: SerializeField] public float Cooldown { get; protected set; }
    public WeaponDefinition(WeaponType weaponType) : base(ItemType.Weapon)
    {
        WeaponType = weaponType;
    }
}

[Serializable]
public class WeaponData : ItemData, IWeapon
{
    public WeaponType WeaponType { get; set; }
    public double LastAttack { get; set; }
    public float Cooldown { get; set; }
}

public interface IWeapon
{
    WeaponType WeaponType { get; }
    double LastAttack { get; }
    float Cooldown { get; }
}