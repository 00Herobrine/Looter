using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Ammunition/New Cartridge")]
public class CartridgeDefintion : ItemStackDefinition, ICaliber
{
    [field: Header("Cartridge Definition")]
    [field: SerializeField] public Vector2 Caliber { get; private set; }
    public CartridgeDefintion() : base(ItemType.Cartridge) { }
}

[Serializable]
public struct PowderLoad
{
    [field: SerializeField] public GunpowderDefinition Powder { get; private set; }
    [field: SerializeField] public float Load { get; private set; }
}