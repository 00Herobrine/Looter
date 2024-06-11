using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public abstract class AbstractItemSlot<T> : MonoBehaviour where T : BaseItem
{
    [field: SerializeField] public Image RarityRef { get; protected set; }
    [field: SerializeField] public Image ImageRef { get; protected set; }
    [field: SerializeField] public ItemType[] BlacklistedTypes { get; private set; }
    [field: SerializeField] public string[] BlacklistedIDs { get; private set; }
    [field: SerializeField] public T Item { get; protected set; }

    private void Awake()
    {
        if (Item != null) SetItemInfo();
    }

    public bool IsBlacklisted(T item) => IsBlacklisted(item.Type) || IsBlacklisted(item.UUID);
    public bool IsBlacklisted(string itemGUID) => BlacklistedIDs.Contains(itemGUID);
    public bool IsBlacklisted(ItemType itemType) => BlacklistedTypes.Contains(itemType);
    public virtual void SetItem(T item)
    {
        if (IsBlacklisted(item)) return;
        Set(item);
    }
    protected virtual void Set(T item)
    {
        Item = item;
        SetItemInfo();
    }
    private void SetItemInfo()
    {
        RarityRef.color = Item.Rarity.Color;
        //ImageRef.sprite = Item.Icon;
    }

}