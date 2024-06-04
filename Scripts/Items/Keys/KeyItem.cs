using UnityEngine;

[CreateAssetMenu(menuName = "Items/New Key")]
public class KeyItem : Item, IUsable<KeyItem>, IHurtable<int>
{
    [field: Header("Key Info")]
    [field: SerializeField] public int HP { get; private set; }
    [field: SerializeField, Range(0,100)] public int MaxHealth { get; private set; }

    public KeyItem() : base(ItemType.Key) { }

    public void Hurt()
    {
        HP--;
        //if(HP < 0)
    }

    public void Use()
    {
        Hurt();
    }
}