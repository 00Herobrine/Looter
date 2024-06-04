using UnityEngine;

[CreateAssetMenu(menuName = "Items/Guns/New Ammo")]
public class Ammo : Item, ICaliber
{
    [SerializeField] public Vector2 Caliber { get; private set; }
    public Ammo() : base(ItemType.Ammo) { }
}
