
using Unity.Netcode;
using Unity.Netcode.Components;
using UnityEngine;

public class ServerRigidBody : NetworkRigidbody
{
    [field: SerializeField] public Rigidbody rb { get; protected set; }
    [field: SerializeField] public float lerpTime  { get; protected set; } = 0.1f; // Adjust as needed

    private void Start()
    {
        rb.isKinematic = IsServer;

    }

    [ServerRpc]
    public void AddForceServerRpc(Vector3 force, ForceMode forceMode = ForceMode.Acceleration)
    {
        rb.AddForce(force, forceMode);
    }

    [ServerRpc]
    public void SetDragServerRpc(float drag)
    {
        rb.drag = drag;
    }

    void Update()
    {
        if (!IsServer)
        {
            //NetworkPosition.Value = rb.position;
            //NetworkRotation.Value = rb.rotation;
        }
    }

    private void FixedUpdate()
    {
        if(IsServer)
        {
            UpdateTransformClientRpc();
        }
    }

    [ClientRpc]
    void UpdateTransformClientRpc()
    {
        transform.position = rb.position;
        transform.rotation = rb.rotation;
    }

    internal void ApplyForce(Vector3 movement)
    {
        rb.AddForce(movement, ForceMode.Acceleration);
    }
}