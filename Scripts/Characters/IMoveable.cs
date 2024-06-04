using UnityEngine;

public interface IMoveable
{
    Rigidbody Rigidbody { get; }
    public abstract void Move(Vector3 direction);
}