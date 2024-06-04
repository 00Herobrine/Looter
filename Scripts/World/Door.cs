using UnityEngine;

public class Door : MonoBehaviour
{
    [field: Header("Door Info")]
    [field: SerializeField] public string Key { get; private set; }
    [field: SerializeField] public bool Locked { get; private set; }

}