using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Equipment/Armored Rig")]
public class ArmoredRig : Equipment
{
    [field: SerializeField] public Dictionary<ArmorRegion, ArmorPlate> ArmorRegions { get; private set; } 
    public ArmoredRig() : base(EquipmentType.Armored_Rig)
    {

    }
}

public enum ArmorRegion
{
    Head,
    Neck,
    Chest,
    Left_Bicep,
    Right_Bicep,
    Stomach,
    Left_Leg,
    Right_Leg,
}
[Serializable]
public struct PlateZone
{
    [field: SerializeField] public ArmorRegion Region { get; private set; }
    [field: SerializeField] public ArmorPlate Plate { get; private set; }
}