using UnityEngine;

[CreateAssetMenu(menuName = "Items/Components/Barrel")]
public class Barrel : GunComponent, ICruical
{
    [field: Header("Barrel Info")]
    [field: SerializeField] public float Length { get; private set; }
    [field: SerializeField] public Vector2 Caliber { get; private set; }
    public bool IsCrucial { get; } = true;
    public Barrel() : base(ComponentType.Barrel) { }
}