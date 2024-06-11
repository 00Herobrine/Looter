using UnityEngine;

public class ChamberBehaviour : GunComponentBehaviour<Chamber>
{
    [field: SerializeField] public Cartridge Cartridge { get; private set; }
    [field: SerializeField] public Transform CartridgeLocation { get; private set; }
    [field: SerializeField] public Quaternion Rotation { get; private set; }

    private void Awake()
    {
        DisplayCartridge();
    }

    public override void Initialize()
    {
        
    }

    private void DisplayCartridge()
    {
        if (Cartridge == null || CartridgeLocation == null) return;
        Instantiate(Cartridge, transform.position, Rotation, CartridgeLocation);
    }
}
