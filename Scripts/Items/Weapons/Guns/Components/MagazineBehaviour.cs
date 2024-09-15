using UnityEngine;

public class MagazineBehaviour : AbstractComponentBehaviour<MagazineData>
{
    [field: SerializeField] public Transform[] CartridgeLocations { get; private set; }
    public override void Initialize()
    {
        for (int i = 0; i < CartridgeLocations.Length; i++)
        {
            CartridgeData cartridge = ItemData.Cartridges[i];
            
        }
    }
}