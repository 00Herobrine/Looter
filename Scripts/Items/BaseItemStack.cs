using UnityEngine;

[CreateAssetMenu(menuName = "Items/New Item Stack")]
public class BaseItemStack : BaseItem
{
    public const int DEFAULT_MAX_STACK = 64;
    public int DefaultCount { get; private set; } = 1;
    public int MaxCount { get; private set; } = DEFAULT_MAX_STACK;
    public BaseItemStack(ItemType itemType) : base(itemType) { }
}