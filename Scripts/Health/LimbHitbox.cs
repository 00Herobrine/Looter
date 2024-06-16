using UnityEngine;

public class LimbHitbox : Hitbox
{
    [field: SerializeField] public Limb Limb { get; private set; }
}