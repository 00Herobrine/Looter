using System;
using UnityEngine;

public abstract class ProjectileAttribute : ScriptableObject, IProjectileAttribute
{
    [field: Header("Projectile Attribute")]
    [field: SerializeField] public string attributeName { get; private set; }
    public abstract void ApplyAttribute(ProjectileBehaviour projectile);
    public virtual void OnProjectileCollision(ProjectileBehaviour projectile, Collision collsion) { }
    public virtual void Update() { }

    public virtual void ApplyImpactEffect(ProjectileBehaviour projectileBehaviour, ContactPoint collision) { }
}