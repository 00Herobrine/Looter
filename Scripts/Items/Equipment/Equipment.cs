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
public abstract class Equipment : ItemObject
{
    [field: Header("Equipment Info")]
    [field: SerializeField] public EquipmentType EquipmentType { get; private set; }
    [field: SerializeField] public EquipmentAttribute[] Attributes { get; private set; }
    public Equipment(EquipmentType equipmentType) : base(ItemType.Equipment)
    {
        EquipmentType = equipmentType;
    }
}