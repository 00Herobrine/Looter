using UnityEditor;
using UnityEngine;

[CreateAssetMenu(menuName = "Vehicles/Weapon")]
public class VehicleWeaponDefintion : ScriptableObject
{
    [field: SerializeField] public string UUID { get; private set; } = GUID.Generate().ToString();
    [field: SerializeField] public AudioClip[] FiringSound { get; private set; }
    [field: SerializeField] public float FireRate { get; private set; }
    [field: SerializeField] public AudioClip[] ReloadingSounds { get; private set; }
    [field: SerializeField] public float ReloadDuration { get; private set; }
}