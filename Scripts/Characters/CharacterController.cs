using Cinemachine.Utility;
using System;
using Unity.Netcode;
using Unity.Netcode.Components;
using UnityEngine;

[RequireComponent(typeof(NetworkObject))]
[RequireComponent(typeof(NetworkRigidbody))]
public class CharacterController : NetworkBehaviour, IDamageable, IMoveable
{
    [field: Header("Character Refs")]
    [field: SerializeField] public Rigidbody Rigidbody { get; protected set; }
    [field: SerializeField] public Animator Animator { get; protected set; }
    [field: SerializeField] public Transform FeetTransform { get; protected set; }
    [field: SerializeField] public Renderer Renderer { get; protected set; }

    [field: Header("Character Info")]
    [field: SerializeField] public MovementData MovementData { get; protected set; }
    [field: SerializeField] public Inventory Inventory { get; protected set; } = new(10, 20);
    [field: SerializeField] public Item HeldItem { get; protected set; }
    [field: SerializeField] public float Health { get; protected set; }
    [field: SerializeField] public bool IsGrounded { get; private set; }
    [field: SerializeField] public float GroundDistance { get; private set; } = 0.1f;

    [field: Header("Character Inputs")]
    [field: SerializeField, Range(0, 1f)] public float moveSpeed { get; protected set; } = 1f;
    [field: SerializeField] public Vector2 look { get; protected set; }
    [field: SerializeField] public Vector2 movement { get; protected set; }
    [field: SerializeField] protected float yRotation;
    [field: SerializeField] protected float xRotation;

    private void Start()
    {
    }

    private void OnEnable()
    {
        
    }

    public override void OnNetworkSpawn()
    {
        if (!IsClient) return;
        Subscribe();
    }

    public override void OnNetworkDespawn()
    {
        Unsubscribe();
    }

    private void Subscribe()
    {

    }

    private void Unsubscribe()
    {

    }

    public void Move(Vector3 direction)
    {
        Vector3 move = direction * (MovementData.WalkSpeed * moveSpeed) * Time.fixedDeltaTime;
        Rigidbody.MovePosition(transform.position + move);
    }

    private void FixedUpdate()
    {
        HandleMovement();
        HandleLook();
        ControlDrag();
    }

    private void HandleMovement()
    {
        if (movement.magnitude > 0) Move(movement);
    }

    void Update()
    {

    }

    protected void HandleLook()
    {
        yRotation += look.x;
        xRotation -= look.y;
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
    }


    private void OnPositionChanged(Vector3 oldPosition, Vector3 newPosition)
    {
        if (!IsClient || !IsOwner) return;
        transform.position = newPosition;
    }

    private void OnRotationChanged(Quaternion oldRotation, Quaternion newRotation)
    {
        if (IsClient && !IsOwner)
        {
            transform.rotation = newRotation;
        }
    }

/*    internal void TransitionState(ICharacterState newState)
    {
        if (!State.AllowedTransitions.Contains(newState.State)) return;
        State?.Exit(this);
        State = newState;
        newState.Enter(this);
    }*/

    internal void SetAnimation(string animationName)
    {
        Debug.Log($"Set animation to: {animationName}");
    }

    protected void GroundCheck()
    {
        IsGrounded = Physics.Raycast(FeetTransform.position, Vector3.down, GroundDistance);
    }

    protected void Jump()
    {
        if (!IsGrounded) return;
        Rigidbody.AddForce(Vector3.up * MovementData.JumpForce, ForceMode.Impulse);
    }

    protected void ControlDrag()
    {

        float drag = MovementData.GroundDrag;
        if (!IsGrounded) drag = MovementData.AirDrag;
        Rigidbody.drag = drag;
    }

    protected void EquipItem<T>(T itemData) where T : Item
    {

    }

    public void QuickAddItem<T>(T itemData) where T : Item => AddItem(itemData, 0, 0);
    public void AddItem<T>(T itemData, int x, int y) where T : Item
    {
        Inventory.SetItem(itemData, x, y);
    }

    public void Damage(float amount)
    {
        Health -= amount;
    }

    public void Kill()
    {
        //throw new NotImplementedException();
    }
}

