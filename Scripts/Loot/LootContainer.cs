using UnityEngine;

[RequireComponent(typeof(Collider))]
public class LootContainer : LootSpawn, IInteractable
{
    [field: Header("Container Info")]
    [field: SerializeField] public float Radius { get; private set; }
    [field: SerializeField] public MinMax Range { get; private set; }
    [field: SerializeField] public Vector2Int Size { get; private set; }
    [field: SerializeField] public Item[] Contents { get; private set; }

    public override void GenerateLoot()
    {
        int items = Random.Range(Range.Min, Range.Max);
        Contents = new Item[Size.x * Size.y];
        for (int i = 0; i < items; i++)
        {
            LootItem lootItem = Pool.GetLootItem();
            Contents[i] = lootItem.Item;
        }
    }
}

public interface IInteractable
{
    float Radius { get; }
}