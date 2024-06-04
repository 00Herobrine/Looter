public interface IItem<T> where T : Item
{
    T ItemData { get; }
}