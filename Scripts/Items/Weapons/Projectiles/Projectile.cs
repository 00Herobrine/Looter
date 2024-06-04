using UnityEngine;

[CreateAssetMenu(menuName = "Items/Weapons/Guns/New Projectile")]
public class Projectile : ItemStack, ICaliber
{
    [field: Header("Projectile Info")]
    [field: SerializeField] public Vector2 Caliber { get; private set; }
    [field: SerializeField] public float Mass { get; private set; }
    [field: SerializeField] public ProjectileAttribute[] Attributes { get; private set; }
    public Projectile() : base(ItemType.Projectile) { }
}