using System;
using System.Collections.Generic;
using Unity.Netcode;
using Unity.Netcode.Components;
using UnityEngine;

[RequireComponent(typeof(NetworkObject))]
[RequireComponent(typeof(NetworkRigidbody))]
public class CharController : NetworkBehaviour, IDamageable, IMoveable
{
    [field: Header("Character Refs")]
    [field: SerializeField] public Rigidbody Rigidbody { get; protected set; }
    [field: SerializeField] public Animator Animator { get; protected set; }
    [field: SerializeField] public Transform FeetTransform { get; protected set; }
    [field: SerializeField] public Renderer Renderer { get; protected set; }

    [field: Header("Character Info")]
    [field: SerializeField] public MovementData MovementData { get; protected set; }
    [field: SerializeField] public CharacterHealth CharHealth { get; protected set; }
    [field: SerializeField] public ForceMode ForceMode { get; protected set; }
    [field: SerializeField] public Inventory Inventory { get; protected set; }
    [field: SerializeField] public Item HeldItem { get; protected set; }
    [field: SerializeField] public float Health { get; protected set; }
    [field: SerializeField] public bool IsGrounded { get; private set; }
    [field: SerializeField] public float GroundSphereSize { get; private set; } = 0.1f;
    [field: SerializeField] public float LootSphereRadius { get; private set; } = 5f;

    [field: Header("Character Inputs")]
    [field: SerializeField, Range(0, 1f)] public float MoveSpeed { get; protected set; } = 1f;
    [field: SerializeField] public Vector2 Look { get; protected set; }
    [field: SerializeField] public Vector3 Movement { get; protected set; }

    protected float yRotation;
    protected float xRotation;

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
        Vector3 move = direction * (MovementData.WalkSpeed * MoveSpeed) * Time.fixedDeltaTime;
        Rigidbody.AddForce(move, ForceMode);
    }

    private void FixedUpdate()
    {
        GroundCheck();
        HandleMovement();
        HandleLook();
        ControlDrag();
    }

    private void HandleMovement()
    {
        if (Movement.magnitude > 0) Move(Movement);
    }

    protected void HandleLook()
    {
        yRotation += Look.x;
        xRotation -= Look.y;
        //transform.RotateAround(transform.position, transform.up, Look.x * MovementData.RotationSpeed * Time.fixedDeltaTime);
        //transform.rotation = Quaternion.Euler(xRotation, transform.rotation.y, yRotation);
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


    #region Inventory/Item Functions
    protected List<Item> GetNearbyItems()
    {
        //Gizmos.DrawWireSphere(transform.position, LootSphereRadius);
        List<Item> items = new();
        if (Physics.SphereCast(transform.position, LootSphereRadius, Vector3.zero, out RaycastHit hit))
        {
            if (hit.collider.TryGetComponent(out Item item))
            {
                items.Add(item);
            }
        }
        return items;
    }
    public void AddItem(Item item)
    {
        Inventory.AddItem(item);
    }
    public void RemoveItem(Item item)
    {

    }
    #endregion

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, LootSphereRadius);
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

    protected void GroundCheck() => IsGrounded = Physics.CheckSphere(FeetTransform.position, GroundSphereSize);
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

