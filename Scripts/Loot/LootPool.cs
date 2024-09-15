using System;
using UnityEngine;

[Serializable, CreateAssetMenu(menuName = "Items/New LootPool")]
public class LootPool : ScriptableObject
{
    [field: SerializeField] public RangeInt ItemsRange { get; private set; }
    [field: SerializeField] public LootItem[] Loot { get; private set; }
    public int TotalWeight
    {
        get {
            int total = 0;
            foreach (LootItem lootItem in Loot)
                total += lootItem.Weight;
            return total;
        }
    }

    public LootItem GetLootItem()
    {
        return Loot[UnityEngine.Random.Range(0, Loot.Length)];
    }
}

[Serializable]
public struct LootItem
{
    [field: SerializeField] public MinMax ItemsCount { get; private set; }
    [field: SerializeField] public ItemDefinition Item { get; private set; }
    [field: SerializeField] public float Scale { get; private set; }
    [field: SerializeField] public Vector3 Rotation { get; private set; }
    [field: SerializeField] public int Weight { get; private set; }
    [field: SerializeField] public string PoolName { get; private set; }
}

[Serializable]
public struct MinMax
{
    public int Min;
    public int Max;
}