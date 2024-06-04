using UnityEngine;

public class InventoryUI : SingletonBehavior<InventoryUI>
{
    [field: SerializeField] public PlayerController Player { get; private set; }
    [field: SerializeField] public Texture2D CellIcon { get; private set; }
    [field: SerializeField] public Texture2D SelectedCellIcon { get; private set; }
}