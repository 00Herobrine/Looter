public class ItemBehaviour : AbstractItemBehaviour<Item>, IDroppable, IPickupable, IEquippable, IUnequippable
{
    protected virtual void Start()
    {
        if (IsServer)
        {

        }
    }

    public void OnPickup() { }

    public void Drop()
    {
        throw new System.NotImplementedException();
    }

    public void Pickup()
    {
        throw new System.NotImplementedException();
    }

    public void Equip()
    {
        throw new System.NotImplementedException();
    }

    public void UnEquip()
    {
        throw new System.NotImplementedException();
    }
}