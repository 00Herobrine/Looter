using UnityEngine;

[CreateAssetMenu(menuName = "Items/ItemDatabase", fileName = "New ItemDatabase")]
public class ItemDatabase : ScriptableObject
{
    [field: SerializeField] public ItemDefinition[] ItemDefinitions { get; private set; }
}