using Unity.Netcode;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CharacterAudio))]
public class CharacterMovement : NetworkBehaviour
{
    [field: SerializeField] public AudioSource AudioSource { get; private set; }
    [field: SerializeField] public MovementSO MovementData { get; private set; }

    public void AttemptMove(Vector3 movement)
    {

    }
}