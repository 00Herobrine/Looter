using UnityEngine;

public abstract class VehicleWeapon : AbstractWeaponBehaviour<VehicleWeaponData>
{
    [field: Header("Weapon Refs")]
    [field: SerializeField] public VehicleWeaponDefintion Definition { get; private set; }
    [field: SerializeField] public Transform Muzzle { get; private set; }
}

public abstract class VehicleWeaponData : WeaponData
{
    public float Damage { get; private set; }
}