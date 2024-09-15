using UnityEngine;

[CreateAssetMenu(menuName = "Items/Components/New Chamber")]
public class ChamberDefinition : GunComponentDefinition
{
    [field: Header("Chamber Data")]
    [field: SerializeField] public CartridgeDefinition Cartridge { get; private set; }
    public ChamberDefinition() : base(ComponentType.Chamber) { }
}