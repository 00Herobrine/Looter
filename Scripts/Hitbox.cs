using Unity.Netcode;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class Hitbox : NetworkBehaviour
{
    public UnityEvent<Collider> OnHitboxHit;

    private void OnTriggerEnter(Collider other)
    {
        
    }
}