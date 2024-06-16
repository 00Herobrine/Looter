using UnityEngine;

public interface IProjectile
{
    string OwnerID { get; }
    float Damage { get; }
    Vector3 Velocity { get; }
}