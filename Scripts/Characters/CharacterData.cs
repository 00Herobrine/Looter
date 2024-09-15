using UnityEngine;

public class CharacterData
{
    [Header("Character Data")]
    [field: SerializeField] public HealthData HealthData { get; private set; }
    [field: SerializeField] public ForceMode ForceMode { get; private set; }
    [field: SerializeField] public InventoryData Inventory { get; private set; }
    [field: SerializeField] public ItemDefinition HeldItem { get; private set; }
    [field: SerializeField] public float Health { get; private set; }
}