using UnityEngine;

[CreateAssetMenu(menuName = "Items/New Item Stack")]
public class ItemStackDefinition : ItemDefinition
{
    public const int DEFAULT_MAX_COUNT = 64;
    public const int DEFAULT_MIN_COUNT = 1;
    [field: SerializeField, Range(DEFAULT_MIN_COUNT, DEFAULT_MAX_COUNT)] public int DefaultCount { get; private set; } = DEFAULT_MIN_COUNT;
    [field: SerializeField, Range(DEFAULT_MIN_COUNT, DEFAULT_MAX_COUNT)] public int MaxCount { get; private set; } = DEFAULT_MAX_COUNT;
    public ItemStackDefinition(ItemType itemType) : base(itemType) { }
}

public class ItemStackData : ItemData
{
    public int Count { get; set; }
    public int MaxCount { get; set; }
}