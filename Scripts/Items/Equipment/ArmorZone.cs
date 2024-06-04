using UnityEngine;

[RequireComponent(typeof(Collider))]
public class ArmorZone : MonoBehaviour
{
    //[field: SerializeField] public ArmoredRig Rig { get; private set; }
    [field: SerializeField] public ArmorRegion ProtectionZone { get; private set; }
    [field: SerializeField] public ArmorPlate Plate { get; private set; }
}