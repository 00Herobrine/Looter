using System;
using UnityEngine;

// The most base of base Items, what everything will be cloned from.
[CreateAssetMenu(menuName = "Items/New Item")]
public class BaseItem : ScriptableObject
{
    [field: Header("Base Item Info")]
    [field: SerializeField] public string UUID { get; private set; } = Guid.NewGuid().ToString();
    [field: SerializeField] public ItemType Type { get; protected set; }
    [field: SerializeField] public string Name { get; protected set; }
    [field: SerializeField, TextArea(2, 5)] public string Description { get; protected set; }
    [field: SerializeField, Min(0)] public int UnitPrice { get; protected set; }
    [field: SerializeField] public Sprite Icon { get; protected set; }
    [field: SerializeField] public Rarity Rarity { get; protected set; }
    [field: SerializeField] public GameObject Prefab { get; private set; }
    [field: SerializeField] public float Radius { get; protected set; }
    public BaseItem(ItemType type)
    { 
        Type = type;
    }
}