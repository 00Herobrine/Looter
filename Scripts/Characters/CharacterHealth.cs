using UnityEngine;

public class CharacterHealth
{
    [field: SerializeField] public Limb[] Limbs { get; private set; }
}

public class Limb : IDamageable, IHealable
{
    public string Name { get; private set; }
    public float MaxHealth { get; private set; }
    public float Health { get; private set; }
    public bool IsCrucial { get; private set; }
    public bool IsBleeding { get; private set; }
    public bool IsBroken { get; private set; }

    public Limb(string name, float maxHealth, float health, bool isBleeding, bool isBroken)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = health;
        IsBleeding = isBleeding;
        IsBroken = isBroken;
    }

    public void Damage(float amount)
    {
        float newHealth = Health - amount;
        if(newHealth <= 0)
        {
            Kill();
        }
    }

    public void Heal(float amount)
    {

    }

    public void Kill()
    {

    }
}