using AYellowpaper.SerializedCollections;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Weapons/New Gun")]
public class Gun : Weapon<Gun>
{
    [field: Header("Gun Data")]
    [field: SerializeField] public int FireRate { get; private set; }
    [field: SerializeField] public ComponentType[] CrucialComponents { get; private set; }
    [field: SerializeField] public SerializedDictionary<ComponentType, GunComponent> Components { get; private set; }
    [field: SerializeField] public Firemode[] Firemodes { get; private set; }
    [field: SerializeField] public Firemode SelectedFiremode { get; private set; }
    public Gun() : base(WeaponType.GUN)
    {

    }
}