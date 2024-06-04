using UnityEngine.Events;

public interface IConsumable : IUsable<Item>
{
    UnityEvent<Item> ConsumedEvent { get; }
    float ConsumeTime { get; }
    virtual void Consumed() { }
}