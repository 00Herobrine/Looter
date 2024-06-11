using UnityEngine;

[CreateAssetMenu(menuName = "Items/Equipment/New Headset")]
public class Headset : Equipment
{
    [field: SerializeField] public CellBlock FoldedShape { get; private set; }
    [field: Header("Headset Info")]
    [field: SerializeField] public AnimationCurve AudioEQ { get; private set; }
    public Headset() : base(EquipmentType.Headset) { }
}