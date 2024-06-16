using UnityEngine;

public class TankCasing : MonoBehaviour, ICaliber
{
    [field: SerializeField] public GunpowderDefinition GunpowderRef { get; private set; }
    [field: SerializeField] public Vector2 Caliber { get; private set; }
}