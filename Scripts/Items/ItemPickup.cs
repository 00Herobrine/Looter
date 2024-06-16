using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class ItemPickup : MonoBehaviour
{
    [field: Header("Pickup Info")]
    [field: SerializeField] private float Range;
    [field: SerializeField] private SphereCollider Collider;

    private void Awake()
    {
        Collider.radius = Range;
    }
}