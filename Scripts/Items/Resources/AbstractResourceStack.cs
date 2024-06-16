public abstract class AbstractResourceStack<T> : ItemStackDefinition where T : ResourceStackData
{
    public AbstractResourceStack() : base(ItemType.Resource) {}
}