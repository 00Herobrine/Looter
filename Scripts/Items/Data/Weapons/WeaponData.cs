using System;
using UnityEngine;

public class weaponData : itemData, IWeaponData
{
    [field: SerializeField] public WeaponType WeaponType { get; private set; }
    [field: SerializeField] public double LastAttack { get; private set; }
    [field: SerializeField] public float Cooldown { get; private set; }
}