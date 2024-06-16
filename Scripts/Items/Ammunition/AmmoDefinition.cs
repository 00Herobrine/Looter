using UnityEngine;

[CreateAssetMenu(menuName = "Items/Ammunition/New Load")]
public class AmmoDefinition : ScriptableObject
{
    public const string AmmoLabel = "Ammunition";
    [field: SerializeField] public CartridgeDefintion Cartridge { get; private set; }
    [field: SerializeField] public ProjectileDefinition Projectile { get; private set; }
    [field: SerializeField] public GunpowderDefinition Gunpowder { get; private set; }
    [field: SerializeField] public float PowderLoad { get; private set; }
    //public AmmoDefinition() : base(ItemType.Ammo) { }
}
