using UnityEngine;

public class CartridgeBehaviour : AbstractItemBehaviour<CartridgeData>
{
    [field: Header("Cartridge Refs")]
    [field: SerializeField] public Transform ProjectileLocation { get; private set; }
    //[field: Header("Cartridge Data")]
    //[field: SerializeField] public PowderLoad Load { get; private set; }
}