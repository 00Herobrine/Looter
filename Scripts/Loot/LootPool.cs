using System;
using UnityEngine;

[Serializable, CreateAssetMenu(menuName = "Items/New LootPool")]
public class LootPool : ScriptableObject
{
    [field: SerializeField] public RangeInt ItemsRange { get; private set; }
    [field: SerializeField] public LootItem[] Loot { get; private set; }
}

[Serializable]
public struct LootItem
{
    [field: SerializeField] public MinMax ItemsCount { get; private set; }
    [field: SerializeField] public Item Item { get; private set; }
    [field: SerializeField] public float Chance { get; private set; }
}

[Serializable]
public struct MinMax
{
    public int Min;
    public int Max;
    public int Value;
}