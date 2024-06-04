using UnityEngine;

public class GunBehaviour : WeaponBehaviour<Gun>
{
    [field: SerializeField] public Gun Gun;
    [field: SerializeField] public GunComponent[] Components { get; private set; }
    public GunBehaviour()
    {

    }
}