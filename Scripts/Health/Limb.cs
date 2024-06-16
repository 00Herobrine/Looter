using System;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Hitbox))]
public class Limb : NetworkBehaviour, IDamageable, IHealable
{
    [field: Header("Limb Refs")]
    [field: SerializeField] public Character Character { get; private set; }
    [field: SerializeField] public LimbDefinition LimbDefinition { get; private set; }
    [field: Header("Limb Info")]
    [field: SerializeField] public LimbData LimbData { get; private set; }
    public UnityEvent<LimbData, LimbData> OnLimbHealthChange;
    public UnityEvent<LimbData, LimbData> OnLimbKill;
    public UnityEvent<LimbData, float> OnLimbHeal;
    public UnityEvent<LimbData, float> OnLimbDamage;
    public float MaxHealth => LimbData.MaxHealth;
    public float Health { 
        get => LimbData.Health; 
        set
        {
            LimbData oldData = LimbData;
            LimbData.Health = value;
            OnLimbHealthChange?.Invoke(oldData, LimbData);
            if (value <= 0) Kill();
        }
    }

    private void Awake()
    {
        //SetLimbData(LimbDefinition);
    }

    private void SetLimbData(ILimbData data)
    {
        LimbData.Name = data.Name;
        LimbData.MaxHealth = data.MaxHealth;
        LimbData.Health = data.Health;
        LimbData.IsCrucial = data.IsCrucial;
        LimbData.IsBroken = data.IsBroken;
        LimbData.Attributes = data.Attributes;
    }

    public void Damage(float damage)
    {
        if (IsServer)
        {
            Health -= damage;
            OnLimbDamage?.Invoke(LimbData, damage);
        }
    }

    public void Heal(float amount)
    {
        Health += amount;
        OnLimbHeal?.Invoke(LimbData, amount);
    }

    private void Kill()
    {
        if (LimbData.Health <= 0 && LimbData.IsCrucial)
            Character.Kill();
    }
}

[Serializable]
public class LimbData : ILimbData
{
    [field: SerializeField] public string Name { get; set; }
    [field: SerializeField] public float MaxHealth { get; set; }
    [field: SerializeField] public float Health { get; set; }
    [field: SerializeField] public bool IsCrucial { get; set; }
    [field: SerializeField] public bool IsBroken { get; set; }
    [field: SerializeField] public HealthAttribute[] Attributes { get; set; }
}

public interface ILimbData : IMaxHealth, IAttributeHaver<HealthAttribute>
{
    public string Name { get; }
    public bool IsCrucial { get; }
    public bool IsBroken { get; }
    public HealthAttribute[] Attributes { get; }
}