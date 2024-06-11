using UnityEngine;

public class ItemBehaviour : AbstractItemBehaviour<Item>, IDroppable, IPickupable, IEquippable, IUnequippable
{
    protected virtual void Start()
    {
        Initialize();
        if (IsServer)
        {

        }
    }
/*
    private void OnDrawGizmosSelected()
    {
        if (gameObject == null) return;
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, ItemData.Radius);
    }*/

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