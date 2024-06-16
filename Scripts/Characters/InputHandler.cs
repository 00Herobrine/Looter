using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

[RequireComponent(typeof(Character))]
public abstract class InputHandler : NetworkBehaviour
{
    [field: SerializeField] public Character Character { get; private set; }
    public CharacterInput Input;
    protected List<IReceiveInput> Subscribers;
    public void AddTicks(IReceiveInput subscriber)
    {
        Subscribers.Add(subscriber);
    }
    public void RemoveTicks(IReceiveInput subscriber)
    {
        Subscribers.Remove(subscriber);
    }

    //void netReceieveInput(PlayerNetworkedInput netInput)
}

public interface IReceiveInput
{

}


public struct CharacterInput 
{
    public bool moving;
    public bool smoothMoving;
    public Vector3 moveDirection;
    public Vector3 smoothMoveDirection;
    public bool aiming;
    public bool smoothAiming;
    public Vector3 aimDirection;
    public Vector3 smoothAimDirection;
    //public CharacterState characterState;
}

public enum CharacterState
{
    Idle,
    Moving,
    Shooting,
    Throwing,
}