using Unity.Netcode;

public interface IStackable
{
    int Count { get; }
    int MaxCount { get; }
}

public interface INetStackable
{
    NetworkVariable<int> Count { get; }
    NetworkVariable<int> MaxCount { get; }
}