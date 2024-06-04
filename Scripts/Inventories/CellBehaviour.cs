using System;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;

public class CellBehaviour : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    [field: SerializeField] public Item ItemData { get; private set; }
    [field: SerializeField] public Sprite CellIcon { get; private set; }
    [field: SerializeField] public Sprite SelectedCellIcon { get; private set; }
    [field: SerializeField] public ItemType[] BlacklistedTypes { get; private set; }
    [field: SerializeField] public string[] BlacklistedIDs { get; private set; }

    public void SetItem(Item item)
    {
        if (IsBlacklisted(item)) return;
        ItemData = item;
    }

    public bool IsBlacklisted(Item item) => IsBlacklisted(item.Type) || IsBlacklisted(item.GUID);
    public bool IsBlacklisted(string itemGUID) => BlacklistedIDs.Contains(itemGUID); 
    public bool IsBlacklisted(ItemType itemType) => BlacklistedTypes.Contains(itemType);

    public void OnPointerEnter(PointerEventData eventData)
    {
        throw new NotImplementedException();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        throw new NotImplementedException();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        throw new NotImplementedException();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        throw new NotImplementedException();
    }
}
