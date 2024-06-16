using UnityEngine;

[CreateAssetMenu(menuName = "Items/Caliber", fileName = "New CaliberDefinition")]
public class CaliberDefinition : ScriptableObject
{
    [field: SerializeField] public Caliber Caliber { get; private set; }
}