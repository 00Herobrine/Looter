using UnityEngine;

public class GunpowderStackData : GunpowderData, IStackable
{
    [field: SerializeField] public int Count { get; private set; }
    [field: SerializeField] public int MaxCount { get; private set; }
} 