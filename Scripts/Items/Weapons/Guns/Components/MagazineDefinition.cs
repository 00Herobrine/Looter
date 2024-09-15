using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Components/New Magazine")]
public class MagazineDefinition : GunComponentDefinition, IMagazine
{
    [field: Header("Magazine Info")]
    [field: SerializeField] public int MaxRounds { get; private set; } = 1;
    [field: SerializeField, Range(0, 1f)] public float Reliability { get; private set; } = 1f;
    [field: SerializeField] public Vector2 Caliber { get; private set; }
    public Stack<CartridgeDefinition> Cartridges { get; private set; }
    public MagazineDefinition() : base(ComponentType.Magazine) { }

    public void Load(CartridgeDefinition cartridge) { Cartridges.Push(cartridge); }
    public CartridgeDefinition Unload() { return Cartridges.Pop(); }
}

public interface IMagazine : ICaliber
{
    int MaxRounds { get; }
    float Reliability { get; }
    Stack<CartridgeDefinition> Cartridges { get; }
}

public class MagazineData : ItemData
{
    public CartridgeData[] Cartridges { get; set; }
}