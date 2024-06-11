using UnityEngine;

public class BarrelBehaviour : GunComponentBehaviour<Barrel>, IDamageable, IHealable, IHeatable
{
    public float Health { get; private set; }
    public float MaxHealth { get; private set; }
    public float Heat { get; private set; }

    public void Damage(float amount)
    {
        float newHealth = Health - Mathf.Abs(amount);
        Health = Mathf.Max(newHealth, 0);
    }

    public void Heal(float amount)
    {
        throw new System.NotImplementedException();
    }
}