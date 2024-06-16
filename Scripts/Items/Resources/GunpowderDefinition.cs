using UnityEngine;

[CreateAssetMenu(menuName = "Items/Resources/New Gunpowder")]
public class GunpowderDefinition : ResourceDefinition
{
    [field: Header("Gunpowder Info")]
    [field: Tooltip("Energy Potential Per Gram")]
    [field: SerializeField, Range(1, 9999)] public float Energy { get; private set; }
    [field: SerializeField, Range(0, 1f)] public float Consistency { get; private set; } = 1f;
    public GunpowderDefinition() { }
}