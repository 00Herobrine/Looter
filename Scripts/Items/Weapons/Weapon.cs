using UnityEngine;

public abstract class Weapon<T> : Item where T : Weapon<T>
{
    [field: Header("Weapon Info")]
    [field: SerializeField] public WeaponType WeaponType { get; private set; }
    public Weapon(WeaponType weaponType) : base(ItemType.Weapon)
    {
        WeaponType = weaponType;
    }
    public Weapon(Weapon<T> weaponData) : base(ItemType.Weapon)
    {
        WeaponType = weaponData.WeaponType;
    }
}