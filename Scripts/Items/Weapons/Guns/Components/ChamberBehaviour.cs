using UnityEngine;

public class ChamberBehaviour : AbstractComponentBehaviour<ChamberData>
{
    [field: Header("Chamber Refs")]
    [field: SerializeField] public Transform CartridgeLocation { get; private set; }
    [field: SerializeField] public Vector3 Rotation { get; private set; }

    private void Awake()
    {
        DisplayCartridge();
    }

    public override void Initialize()
    {
        
    }

    private void DisplayCartridge()
    {
        if (ItemData.Cartridge == null || CartridgeLocation == null) return;
        Instantiate(ItemData.Cartridge.Definition.Prefab, transform.position, Quaternion.Euler(Rotation), CartridgeLocation);
    }
}

public interface IChamb : ICaliber
{
    CartridgeData Cartridge { get; }

}

public class ChamberData : ItemData
{
    public CartridgeData Cartridge;
}