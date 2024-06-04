public delegate void ItemEventHandler(ItemBehaviour item);

public static class ItemEvents
{
    public static event ItemEventHandler OnItemPickedUp;
    public static event ItemEventHandler OnItemDropped;
    public static event ItemEventHandler OnItemUsed;
    public static event ItemEventHandler OnItemEquipped;
    public static event ItemEventHandler OnItemUnequipped;

    public static void RaiseItemPickedUp(ItemBehaviour item)
    {
        OnItemPickedUp?.Invoke(item);
    }

    public static void RaiseItemDropped(ItemBehaviour item)
    {
        OnItemDropped?.Invoke(item);
    }

    public static void RaiseItemUsed(ItemBehaviour item)
    {
        OnItemUsed?.Invoke(item);
    }

    public static void RaiseItemEquipped(ItemBehaviour item)
    {
        OnItemEquipped?.Invoke(item);
    }

    public static void RaiseItemUnequipped(ItemBehaviour item)
    {
        OnItemUnequipped?.Invoke(item);
    }
}