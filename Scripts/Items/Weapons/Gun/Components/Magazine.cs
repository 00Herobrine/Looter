using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Components/New Magazine")]
public class Magazine : GunComponent, ICaliber
{
    [field: Header("Magazine Info")]
    [field: SerializeField] public int MaxRounds { get; private set; } = 1;
    [field: SerializeField, Range(0, 1f)] public float Reliability { get; private set; } = 1f;
    [field: SerializeField] public Vector2 Caliber { get; private set; }
    public Stack<Cartridge> Cartridges { get; private set; }
    public Magazine() : base(ComponentType.Magazine) { }

    public void Load(Cartridge cartridge) { Cartridges.Push(cartridge); }
    public Cartridge Unload() { return Cartridges.Pop(); }
}