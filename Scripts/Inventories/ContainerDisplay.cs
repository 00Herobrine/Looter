using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ContainerDisplay : MonoBehaviour
{
    [field: Header("Container Display Info")]
    [field: SerializeField] public GridLayoutGroup GridLayout { get; private set; }
    [field: SerializeField] public GameObject ItemSlotPrefab { get; private set; }
    //[field: SerializeField] public Container Container { get; private set; } = null;
    [field: SerializeField] public ItemSlot[] Slots { get; private set; }
    [field: SerializeField] public ItemObject TestItem { get; private set; }
    [field: SerializeField] public int Columns { get; private set; }
    [field: SerializeField] public int Rows { get; private set; }
    private RectTransform rectTransform;
    public UnityEvent ItemAddedEvent;

    private void Awake()
    {
        InitializeGrid();
    }

    private void InitializeGrid()
    {
        GridLayout.constraint = GridLayoutGroup.Constraint.FixedColumnCount;
        GridLayout.constraintCount = Columns;
        int slotCount = Columns * Rows;
        Slots = new ItemSlot[slotCount];
        for (int i = 0; i < slotCount; i++)
        {
            GameObject slotObject = Instantiate(ItemSlotPrefab, transform);
            ItemSlot slot = slotObject.GetComponent<ItemSlot>();
            Slots[i] = slot;
            if(i == 0) slot.SetItem(TestItem);
        }
    }

    private void LoadContents()
    {
        
        //Container.Contents[0, 0].SetItem(TestItem);
    }

/*    public void SetContainer(Container container)
    {
        Container = container;
        InitializeGrid();
        LoadContents();
    }*/
}