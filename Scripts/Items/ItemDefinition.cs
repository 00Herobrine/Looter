using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/New Item")]
public class ItemDefinition : ScriptableObject, IItemDefinition
{
    [field: Header("Base Item Info")]
    [field: SerializeField] public string UUID { get; protected set; } = Guid.NewGuid().ToString();
    [field: SerializeField] public ItemType Type { get; protected set; }
    [field: SerializeField] public string Name { get; protected set; }
    [field: SerializeField, TextArea(2, 5)] public string Description { get; protected set; }
    [field: SerializeField, Min(0)] public int UnitPrice { get; protected set; }
    [field: SerializeField] public Sprite Icon { get; protected set; }
    [field: SerializeField] public Rarity Rarity { get; protected set; }
    [field: SerializeField] public GameObject Prefab { get; protected set; }
    [field: SerializeField] public float Radius { get; protected set; }
    [field: SerializeField] public CellBlock Shape { get; protected set; }
    public ItemDefinition(ItemType type)
    { 
        Type = type;
    }
}

/*[Serializable]
public class ItemDefinitionData : IItemDefinition
{
    public string UUID { get; set; }
    public ItemType Type { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int UnitPrice { get; set; }
    public float Radius { get; set; }
    public Sprite Icon { get; set; }
    public Rarity Rarity { get; set; }
    public GameObject Prefab { get; set; }
}*/

public interface IItemDefinition
{
    string UUID { get; }
    ItemType Type { get; }
    string Name { get; }
    string Description { get; }
    int UnitPrice { get; }
    float Radius { get; }
    Sprite Icon { get; }
    Rarity Rarity { get; }
    GameObject Prefab { get; }
}