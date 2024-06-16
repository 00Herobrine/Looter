using UnityEngine;

[CreateAssetMenu(menuName = "Items/Components/Barrel")]
public class BarrelDefinition : ComponentDefinition
{
    [field: Header("Barrel Info")]
    [field: SerializeField] public float Length { get; private set; }
    [field: SerializeField] public Vector2 Caliber { get; private set; }
    public BarrelDefinition() : base(ComponentType.Barrel) { }
}