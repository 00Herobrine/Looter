using System.Collections.Generic;
using Unity.Netcode;
using Unity.Netcode.Components;
using UnityEngine;

[RequireComponent(typeof(Health))]
[RequireComponent(typeof(NetworkRigidbody))]
[RequireComponent(typeof(CharacterMovement))]
public class Character : NetworkBehaviour
{
    [field: Header("Character Refs")]
    [field: SerializeField] public Rigidbody Rigidbody { get; protected set; }
    [field: SerializeField] public Animator Animator { get; protected set; }
    [field: SerializeField] public Transform[] FeetTransform { get; protected set; }
    [field: SerializeField] public Renderer Renderer { get; protected set; }
    [field: SerializeField] public CharacterData CharacterData { get; protected set; }

    [field: Header("Character Info")]
    [field: SerializeField, Range(0, 1f)] public float MoveSpeed { get; protected set; } = 1f;
    [field: SerializeField] public InputHandler InputHandler { get; protected set; }
    public bool IsGrounded { get; protected set; }

    protected float yRotation;
    protected float xRotation;


    private void FixedUpdate()
    {
        GroundCheck();
        HandleMovement();
        HandleLook();
        ControlDrag();
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

    protected virtual void Subscribe() { }
    private void Unsubscribe() { }

    public void Move(Vector3 direction)
    {
        Vector3 move = direction * (GameManager.Instance.MovementData.WalkSpeed * MoveSpeed) * Time.fixedDeltaTime;
        Rigidbody.AddForce(move, GameManager.Instance.ForceMode);
    }

    private void MovePlayerServer()
    {
        MovePlayerServerRpc(InputHandler.Input.moveDirection);
    }

    [ServerRpc]
    private void MovePlayerServerRpc(Vector3 moveDirection)
    {
        Rigidbody.AddForce(moveDirection, GameManager.Instance.ForceMode);

    }


    private void HandleMovement()
    {
        //if (Movement.magnitude > 0) Move(Movement);
    }

    protected void HandleLook()
    {
        //yRotation += Look.x;
        //xRotation -= Look.y;
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
    protected List<ItemDefinition> GetNearbyItems()
    {
        //Gizmos.DrawWireSphere(transform.position, LootSphereRadius);
        List<ItemDefinition> items = new();
        if (Physics.SphereCast(transform.position, GameManager.Instance.LootSphereRadius, Vector3.zero, out RaycastHit hit))
        {
            if (hit.collider.TryGetComponent(out ItemDefinition item))
            {
                items.Add(item);
            }
        }
        return items;
    }
    public void AddItem(ItemDefinition item)
    {
        //Inventory.AddItem(item);
    }
    public void RemoveItem(ItemDefinition item)
    {

    }
    #endregion

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, GameManager.Instance.LootSphereRadius);
        Gizmos.color = Color.red;
        foreach (Transform foot in FeetTransform)
            Gizmos.DrawWireSphere(foot.position, GameManager.Instance.GroundSphereSize);
    }

    protected void GroundCheck()
    {
        foreach (Transform foot in FeetTransform)
            if (Physics.CheckSphere(foot.position, GameManager.Instance.GroundSphereSize)) IsGrounded = true;
        IsGrounded = false;
    }
    protected void Jump()
    {
        if (!IsGrounded) return;
        Rigidbody.AddForce(Vector3.up * GameManager.Instance.MovementData.JumpForce, ForceMode.Impulse);
    }

    protected void ControlDrag()
    {
        float drag = GameManager.Instance.MovementData.GroundDrag;
        if (!IsGrounded) drag = GameManager.Instance.MovementData.AirDrag;
        Rigidbody.drag = drag;
    }

    protected void EquipItem<T>(T itemData) where T : ItemDefinition
    {

    }

    public void QuickAddItem<T>(T itemData) where T : ItemDefinition => AddItem(itemData, 0, 0);
    public void AddItem<T>(T itemData, int x, int y) where T : ItemDefinition
    {
        //Inventory.SetItem(x, y, itemData);
    }

    public void Kill()
    {
        //throw new NotImplementedException();
    }
}