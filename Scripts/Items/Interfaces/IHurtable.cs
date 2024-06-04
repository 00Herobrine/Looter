public interface IHurtable<T> : IHP<T>
{
    void Hurt();
}

public interface IHP<T>
{
    T HP { get; }
}