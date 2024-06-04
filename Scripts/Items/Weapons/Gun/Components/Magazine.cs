using System.Collections.Generic;

public class Magazine : Item
{
    public Stack<Cartridge> Cartridges { get; private set; }
    public Magazine() : base(ItemType.Component) { }

    public void Load(Cartridge cartridge) { Cartridges.Push(cartridge); }
    public Cartridge Unload() { return Cartridges.Pop(); }
}