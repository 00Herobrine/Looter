using Unity.Netcode;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [field: SerializeField] public CharacterHealthData HealthData { get; private set; }
    [field: SerializeField] public Limb[] Limbs { get; private set; }
    public float Total;
    public float MaxHealth { get; private set; }

    private void Update()
    {
        Total = GetTotal();
    }

    private void Awake()
    {
        //AttachLimbs
    }

    public float GetTotal()
    {
        float TotalHealth = 0;
        foreach (Limb Limb in Limbs)
            TotalHealth += Limb.Health;
        return TotalHealth;
    }
    public UnityEvent<Vector3, NetworkObject> OnDeath;
    public UnityEvent<HealthChangedEventArgs> OnHealthChanged;
}

public struct HealthChangedEventArgs
{
    public CharacterHealthData OldHealth { get; }
    public CharacterHealthData NewHealth { get; }
}