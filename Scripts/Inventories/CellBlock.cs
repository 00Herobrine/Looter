using UnityEngine;

[CreateAssetMenu(menuName = "Inventory/Cell Block")]
public class CellBlock : ScriptableObject
{
    public Vector2Int Size { get; set; } = Vector2Int.one;
    public bool[,] ActiveCells { get; set; }
    public int Width => Size.x;
    public int Height => Size.y;

    public CellBlock(Vector2Int size)
    {
        Size = size;
        ActiveCells = new bool[size.x, size.y];
    }
    public CellBlock(Vector2Int size, bool[,] activeCells)
    {
        Size = size;
        ActiveCells = activeCells;
    }

/*    private void OnValidate()
    {
        if (ActiveCells == null || ActiveCells.GetLength(0) != Width || ActiveCells.GetLength(1) != Width)
            ActiveCells = new bool[Width, Height];
    }*/
}