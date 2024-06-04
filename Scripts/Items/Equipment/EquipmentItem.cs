using UnityEngine;

public enum EquipmentType
{
    Helemt,
    Headset,
    Rig,
    Armored_Rig,
    Plate_Carrier,
    Plate,
}
public abstract class EquipmentItem : Item
{
    [field: Header("Equipment Info")]
    [field: SerializeField] public EquipmentType EquipmentType { get; private set; }
    [field: SerializeField] public EquipmentAttribute[] Attributes { get; private set; }
    public EquipmentItem(EquipmentType equipmentType) : base(ItemType.Equipment)
    {
        EquipmentType = equipmentType;
    }
}