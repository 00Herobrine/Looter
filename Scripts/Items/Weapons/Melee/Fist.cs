using UnityEngine;

public class Fist : Weapon<WeaponData>
{
    //public class Fist() : base(WeaponType.MELEE) { }
    public override void Use()
    {
        throw new System.NotImplementedException();
    }
}

public class FistDefinition : WeaponDefinition
{
    public FistDefinition() : base(WeaponType.MELEE) { }
}