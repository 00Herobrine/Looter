using UnityEngine;

[CreateAssetMenu(menuName = "Items/New Rarity")]
public class Rarity : ScriptableObject
{
    [field: Header("Rarity Info")]
    [field: SerializeField] public string Name { get; private set; }
    [field: SerializeField] public Color Color { get; private set; }
}
