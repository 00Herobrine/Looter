using UnityEngine;

[CreateAssetMenu(menuName = "Items/Components/New Chamber")]
public class Chamber : GunComponent
{
    [field: Header("Chamber Data")]
    [field: SerializeField] public Cartridge Cartridge { get; private set; }
    public Chamber() : base(ComponentType.Chamber) { }
}