using UnityEngine.Events;

public interface IConsumable : IUsable<ItemDefinition>
{
    UnityEvent<ItemDefinition> ConsumedEvent { get; }
    float ConsumeTime { get; }
    virtual void Consumed() { }
}