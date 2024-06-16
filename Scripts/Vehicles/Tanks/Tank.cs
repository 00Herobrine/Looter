using UnityEngine;

public class Tank : MonoBehaviour
{
    [field: SerializeField] public Engine[] Engines { get; private set; }
    [field: SerializeField] public VehicleWeapon[] Weapons { get; private set; }

}
