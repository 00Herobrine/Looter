using UnityEngine;

[CreateAssetMenu(menuName = "Items/Weapons/Melee")]
public class MeleeDefinition : WeaponDefinition
{
    public MeleeDefinition() : base(WeaponType.MELEE) { }
}