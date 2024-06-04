using UnityEngine.Events;

public interface IUsable<T>
{
    //UnityEvent<T> UseEvent { get; }
    //UnityEvent<T> UsedEvent { get; }
    void Use();
}