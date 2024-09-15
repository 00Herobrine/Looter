using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Ammunition/New Projectile")]
public class ProjectileDefinition : ItemStackDefinition, ICaliber
{
    [field: Header("Projectile Info")]
    [field: SerializeField] public Vector2 Caliber { get; private set; }
    [field: SerializeField] public float Mass { get; private set; }
    [field: SerializeReference] public List<AbilityEffect> Attributes { get; private set; }
    public ProjectileDefinition() : base(ItemType.Projectile) { }
}