public class BarrelData : GunComponent, ICruical
{
    public bool IsCrucial { get; } = true;
    public BarrelData() : base(ComponentType.Barrel) { }
}