using UnityEngine;

public class MagazineBehaviour : GunComponentBehaviour<Magazine>
{
    [field: SerializeField] public Transform[] CartridgeLocations { get; private set; }
    public override void Initialize()
    {
        for (int i = 0; i < CartridgeLocations.Length; i++)
        {
            Cartridge cartridge = ItemData.Cartridges.ToArray()[i];
            
        }
    }
}