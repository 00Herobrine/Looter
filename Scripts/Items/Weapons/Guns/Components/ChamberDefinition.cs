using UnityEngine;

[CreateAssetMenu(menuName = "Items/Components/New Chamber")]
public class ChamberDefinition : ComponentDefinition
{
    [field: Header("Chamber Data")]
    [field: SerializeField] public CartridgeDefintion Cartridge { get; private set; }
    public ChamberDefinition() : base(ComponentType.Chamber) { }
}