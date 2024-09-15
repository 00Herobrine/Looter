using System.Diagnostics;

public abstract class AttachmentDefinition : ItemDefinition, IAttachable
{
    public AttachmentDefinition() : base(ItemType.Attachment) { }

    public void Attach(GunController gunController)
    {
        Debug.WriteLine($"Attached ${Name} to {gunController.Definition.Name}");
    }
}

public interface IAttachable
{
    public abstract void Attach(GunController gunController);
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