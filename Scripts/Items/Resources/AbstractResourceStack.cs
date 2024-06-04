public abstract class AbstractResourceStack<T> : BaseItemStack where T : ResourceStackData
{
    public AbstractResourceStack() : base(ItemType.Resource) {}
}