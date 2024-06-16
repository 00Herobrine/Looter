using UnityEditor.MemoryProfiler;
using UnityEngine;

public class TankCannon : VehicleWeapon, IChamber
{
    [field: SerializeField] public Vector2 Caliber { get; private set; }
    [field: SerializeField] public CartridgeDefintion Cartridge { get; private set; }
    //[field: SerializeField] public Transform CartridgeLocation { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void AttemptShoot()
    {
        
    }

    private void Shoot()
    {
        Attack();
        PlayEffects();
    }

    public virtual void PlayEffects()
    {
        //Muzzle
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Use()
    {
        AttemptShoot();
    }
}

public class TankCannonData
{
    public string UUID { get; private set; }
}
