public class GunAttachment : ItemObject
{
    public GunAttachment() : base(ItemType.Attachment) { }
}

public struct ConnectionPoint
{
    ConnectionType Connection { get; set; }
}

public enum ConnectionType
{
    Mount, Rail
}

public enum MountType
{
    DoveTail,
}

public enum RailType
{
    Picatinny, Weaver, Keymod, MLOK
}