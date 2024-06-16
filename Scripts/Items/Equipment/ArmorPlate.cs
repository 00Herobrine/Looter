using UnityEngine;

public enum Material
{
    Steel,
    Kevlar,
    Ceramic,
    Titanium
}

[CreateAssetMenu(menuName = "Items/Equipment/New Armor Plate")]
public class ArmorPlate : ItemObject, IDamageable, IHealable
{
    [field: Header("Armor Info")]
    [field: SerializeField] public Material Material { get; private set; }
    [field: SerializeField] public float Health { get; private set; }
    [field: SerializeField] public float MaxHealth { get; private set; }
    [field: SerializeField] public Vector3 Size { get; private set; }

    public ArmorPlate() : base(ItemType.Consumable) { }

    public void Heal(float amount)
    {
        float newHealth = Health + amount;
        Health = Mathf.Min(newHealth, MaxHealth);
    }

    public void Damage(float amount)
    {
        float newHealth = Health - amount;
        Health = Mathf.Max(newHealth, 0);
    }
}