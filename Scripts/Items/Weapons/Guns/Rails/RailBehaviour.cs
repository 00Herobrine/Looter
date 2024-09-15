using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class RailBehaviour : MonoBehaviour
{
    [Header("Rail Info")]
    [field: SerializeField] public RailDefinition Definition { get; protected set; }
    [field: SerializeField] public BoxCollider Collider { get; protected set; }
    [field: Header("Rail Data")]
    public RailSlot[] RailSlots { get; protected set; }
}

public class RailSlot
{

}
