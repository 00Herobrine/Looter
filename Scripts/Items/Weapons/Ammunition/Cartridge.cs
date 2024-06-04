using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Weapons/Guns/New Cartridge")]
public class Cartridge : ItemStack, ICaliber
{
    [field: Header("Cartridge Info")]
    [field: SerializeField] public Vector2 Caliber { get; private set; }
    [field: SerializeField] public Projectile Projectile { get; private set; }
    [field: SerializeField] public PowderLoad Load { get; private set; } 

    public Cartridge() : base(ItemType.Cartridge) { }
}

[Serializable]
public struct PowderLoad
{
    [field: SerializeField] public GunpowderData Powder { get; private set; }
    [field: SerializeField] public float Load { get; private set; }
}