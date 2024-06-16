using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Components/New Magazine")]
public class MagazineDefinition : ComponentDefinition, ICaliber
{
    [field: Header("Magazine Info")]
    [field: SerializeField] public int MaxRounds { get; private set; } = 1;
    [field: SerializeField, Range(0, 1f)] public float Reliability { get; private set; } = 1f;
    [field: SerializeField] public Vector2 Caliber { get; private set; }
    public Stack<CartridgeDefintion> Cartridges { get; private set; }
    public MagazineDefinition() : base(ComponentType.Magazine) { }

    public void Load(CartridgeDefintion cartridge) { Cartridges.Push(cartridge); }
    public CartridgeDefintion Unload() { return Cartridges.Pop(); }
}

public class MagazineData : ItemData
{
    public CartridgeData[] Cartridges { get; set; }
}