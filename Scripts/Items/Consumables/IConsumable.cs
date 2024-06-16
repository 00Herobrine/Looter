using UnityEngine.Events;

public interface IConsumable : IUsable<ItemObject>
{
    UnityEvent<ItemObject> ConsumedEvent { get; }
    float ConsumeTime { get; }
    virtual void Consumed() { }
}