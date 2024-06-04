using UnityEngine;

public class ChamberBehaviour : GunComponentBehaviour<Chamber>
{
    [field: SerializeField] public Cartridge Cartridge { get; private set; }
    [field: SerializeField] public Transform CartridgeLocation { get; private set; }
    [field: SerializeField] public Quaternion Rotation { get; private set; }

    private void Awake()
    {
        Instantiate(Cartridge, transform.position, Rotation, CartridgeLocation);
    }
}
