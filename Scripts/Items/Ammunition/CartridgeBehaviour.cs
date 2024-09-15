using System;
using UnityEngine;

public class CartridgeBehaviour : AbstractItemBehaviour<CartridgeData>
{
    [field: Header("Cartridge Refs")]
    [field: SerializeField] public CartridgeDefinition cartridgeDefintion { get; private set; }
    [field: SerializeField] public Transform ProjectileLocation { get; private set; }
    //[field: Header("Cartridge Data")]
    //[field: SerializeField] public PowderLoad Load { get; private set; }

    private void Awake()
    {
        if (cartridgeDefintion != null)
        {
            ItemData = new CartridgeData(cartridgeDefintion.UUID);
        }
            
    }

    public override void Initialize()
    {
        
    }
}