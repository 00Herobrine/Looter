using UnityEngine;

public class FistBehaviour : WeaponBehaviour<FistData>
{

}

[CreateAssetMenu(menuName = "Items/Weapons/New Fist")]
public class FistData : Weapon<FistData>
{
    public FistData() : base(WeaponType.MELEE) { }
}