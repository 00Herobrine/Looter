using UnityEngine;

public class TankProjectile : MonoBehaviour
{
    [field: SerializeField] public ProjectileDefinition Definition { get; private set; }
}