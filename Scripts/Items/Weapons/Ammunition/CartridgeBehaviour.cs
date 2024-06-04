using UnityEngine;

public class CartridgeBehaviour : AbstractItemBehaviour<Cartridge>
{
    [field: Header("Cartridge")]
    [field: SerializeField] public PowderLoad Load { get; private set; }
}