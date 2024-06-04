using UnityEngine;

public interface IProjectileAttribute
{
    void ApplyAttribute(ProjectileBehaviour projectile);
    void OnProjectileCollision(ProjectileBehaviour projectile, Collision collision);
}