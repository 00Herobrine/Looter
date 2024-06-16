using UnityEngine;

public class CannonDefintion : VehicleWeaponDefintion
{
    [field: Header("Cannon Definition")]
    [field: SerializeField] public float RotationSpeed { get; private set; }
}