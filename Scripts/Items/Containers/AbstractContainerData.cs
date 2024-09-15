public abstract class AbstractContainerData<T> where T : AbstractContainerData<T>
{
    T[] Contents { get; set; }
    public virtual T[] GetContents() => Contents;
    public virtual void SetContents(T[] contents) => Contents = contents;

}