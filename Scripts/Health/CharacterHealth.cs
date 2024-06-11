using System;
using UnityEngine;

[Serializable]
public class CharacterHealth
{
    [field: SerializeField] public Limb[] Limbs { get; private set; }
}

[Serializable]
public class Limb : IDamageable, IHealable
{
    [field: SerializeField] public string Name { get; private set; }
    [field: SerializeField] public float MaxHealth { get; private set; }
    [field: SerializeField] public float Health { get; private set; }
    [field: SerializeField] public bool IsCrucial { get; private set; }
    [field: SerializeField] public bool IsBroken { get; private set; }
    [field: SerializeField] public HealthAttribute[] Attributes { get; private set; }

    public Limb(string name, float maxHealth, float health)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = health;
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