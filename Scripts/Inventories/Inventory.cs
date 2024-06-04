using System;
using UnityEngine;

[Serializable]
public struct Inventory
{
    [field: Header("Inventory Info")]
    [field: SerializeField] public Vector2Int Size { get; private set; }
    [field: SerializeField] public CellBehaviour[,] Contents { get; private set; }

    public Inventory(int width, int height)
    {
        Size = new(width, height);
        Contents = new CellBehaviour[width, height];
    }

    public bool SetItem<T>(T item, Vector2Int pos) where T : Item => SetItem(item, pos.x, pos.y);
    public bool SetItem<T>(T item, int x, int y) where T : Item
    {
        if(CanPlaceItem(item, new Vector2Int(x, y))) return false;
        Contents[x, y].SetItem(item);
        return true;
    }

    private bool CanPlaceItem(Item item, Vector2Int position)
    {
        for (int x = 0; x < item.Width; x++)
        {
            for (int y = 0; y < item.Height; y++)
            {
                Vector2Int slotPos = position + new Vector2Int(x, y);
                if (!IsValidSlot(slotPos) || Contents[slotPos.x, slotPos.y].ItemData != null)
                {
                    return false;
                }
            }
        }
        return true;
    }

    private bool IsValidSlot(Vector2Int position) => position.x >= 0 && position.y >= 0 && position.x < Contents.GetLength(0) && position.y < Contents.GetLength(1);
}
