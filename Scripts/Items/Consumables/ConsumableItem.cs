using UnityEngine;

public class ConsumableItem : ItemStackDefinition
{
    [field: Header("Consumable Info")]
    [field: SerializeField] public float ConsumeTime { get; private set; }

    public ConsumableItem() : base(ItemType.Consumable)
    {

    }

    public void Consumed()
    {
        //throw new NotImplementedException();
    }
}