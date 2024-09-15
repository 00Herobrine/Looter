using UnityEngine;

public class Item
{
    public const int MAX_UNIT_PRICE = int.MaxValue;
    [field: SerializeField] public string ItemID { get; protected set; }
    [field: SerializeField] public string InstanceID { get; protected set; }
    [field: SerializeField] public DefinitionType ItemType { get; protected set; }
    [field: SerializeField] public Rarity Rarity { get; protected set; }
    [field: SerializeField] public GameObject Prefab { get; protected set; }
    [field: SerializeField] public CellBlock Shape { get; protected set; }
    [field: SerializeField] public string Name { get; protected set; }
    [field: SerializeField, TextArea(2, 5)] public string Description { get; protected set; }
    [field: SerializeField, Range(0, MAX_UNIT_PRICE)] public int UnitPrice { get; protected set; }
    [field: SerializeField] public ItemDefinition Defintion { get; protected set; }
    public Item(string ItemID, string name) {
        
     }
}