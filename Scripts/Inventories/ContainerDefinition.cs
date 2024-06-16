using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(menuName = DefinitionCategories.Inventory + "/Container")]
public class ContainerDefinition : ScriptableObject
{
    [field: Header("Container Info")]
    [field: SerializeField] public Vector2Int Size { get; private set; }
    [field: SerializeField] public CellBlock[] Blocks { get; private set; }
    [field: SerializeField] public ItemSlot[,] Contents { get; private set; }
    public int Columns { get; private set; }
    public int Rows { get; private set; }
    public event Action ItemAddedCallback;

    public ContainerDefinition(int columns, int rows)
    {
        Size = new(columns, rows);
        Contents = new ItemSlot[columns, rows];
        Columns = columns;
        Rows = rows;
    }

    public bool AddItem<T>(T Item) where T : ItemObject
    {
        return false;
    }
    public bool SetItem<T>(T item, int x, int y) where T : ItemObject => SetItem(item, new(x, y));
    public bool SetItem<T>(T item, Vector2Int pos) where T : ItemObject
    {
        if (CanPlaceItem(item, pos)) return false;
        Contents[pos.x, pos.y].SetItem(item);
        ItemAddedCallback.Invoke();
        return true;
    }

    private bool CanPlaceItem(ItemObject item, Vector2Int position)
    {
        for (int x = 0; x < item.Width; x++)
        {
            for (int y = 0; y < item.Height; y++)
            {
                Vector2Int slotPos = position + new Vector2Int(x, y);
                if (!IsValidSlot(slotPos) || Contents[slotPos.x, slotPos.y].Item != null)
                {
                    return false;
                }
            }
        }
        return true;
    }

    private bool IsValidSlot(Vector2Int position) => position.x >= 0 && position.y >= 0 && position.x < Contents.GetLength(0) && position.y < Contents.GetLength(1);
}