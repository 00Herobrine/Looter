using UnityEngine;

public class Fist : AbstractWeaponBehaviour<WeaponData>
{
    //public class Fist() : base(WeaponType.MELEE) { }

}

public class FistDefinition : WeaponDefinition
{
    public FistDefinition() : base(WeaponType.MELEE) { }
}